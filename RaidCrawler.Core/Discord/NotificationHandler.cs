using PKHeX.Core;
using RaidCrawler.Core.Interfaces;
using RaidCrawler.Core.Structures;
using SysBot.Base;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Runtime.InteropServices.ObjectiveC;
using static System.Net.WebRequestMethods;

namespace RaidCrawler.Core.Discord;

public class NotificationHandler
{
    protected readonly HttpClient _client = new();
    protected IWebhookConfig _config;
    protected virtual string[]? DiscordWebhooks {  get {  return _config.EnableNotification ? _config.DiscordWebhook.Split(',') : null; } }
    protected virtual string MessageContent { get { return _config.DiscordMessageContent; } }

    public NotificationHandler(in IWebhookConfig config)
    {
        _config = config;
    }

    public virtual async Task SendNotification(ITeraRaid encounter, Raid raid, RaidFilter filter, string time, IReadOnlyList<(int, int, int)> RewardsList,
        string hexColor, string spriteName, CancellationToken token
    )
    {
        if (DiscordWebhooks is null || !_config.EnableNotification)
            return;

        var webhook = GenerateWebhook(encounter, raid, filter, time, RewardsList, hexColor, spriteName);
        var content = new StringContent(JsonSerializer.Serialize(webhook), Encoding.UTF8, "application/json");
        foreach (var url in DiscordWebhooks)
            await _client.PostAsync(url.Trim(), content, token).ConfigureAwait(false);
    }

    public async Task SendErrorNotification(string error, string caption, CancellationToken token)
    {
        if (DiscordWebhooks is null || !_config.EnableNotification)
            return;

        var instance = _config.InstanceName != "" ? $"RaidCrawler {_config.InstanceName}" : "RaidCrawler";
        var webhook = new
        {
            username = instance,
            avatar_url = "https://www.serebii.net/scarletviolet/ribbons/mightiestmark.png",
            content = MessageContent,
            embeds = new List<object>
            {
                new
                {
                    title = caption != "" ? caption : "RaidCrawler Error",
                    description = error,
                    color = 0xf7262a,
                },
            },
        };

        var content = new StringContent(JsonSerializer.Serialize(webhook), Encoding.UTF8, "application/json");
        foreach (var url in DiscordWebhooks)
            await _client.PostAsync(url.Trim(), content, token).ConfigureAwait(false);
    }

    public async Task SendScreenshot(ISwitchConnectionAsync nx, CancellationToken token)
    {
        if (DiscordWebhooks is null || !_config.EnableNotification)
            return;

        var data = await nx.PixelPeek(token).ConfigureAwait(false);
        var content = new MultipartFormDataContent();
        var info = new
        {
            username = "RaidCrawler",
            avatar_url = "https://www.serebii.net/scarletviolet/ribbons/mightiestmark.png",
            content = "Switch Screenshot",
        };

        var basic_info = new StringContent(JsonSerializer.Serialize(info), Encoding.UTF8, "application/json");
        content.Add(basic_info, "payload_json");
        content.Add(new ByteArrayContent(data), "screenshot.jpg", "screenshot.jpg");
        foreach (var url in DiscordWebhooks)
            await _client.PostAsync(url.Trim(), content, token).ConfigureAwait(false);
    }

    protected object GenerateWebhook(ITeraRaid encounter, Raid raid, RaidFilter filter, string time, IReadOnlyList<(int, int, int)> rewardsList, string hexColor, string spriteName, string eventType = "webhook")
    {
        var strings = GameInfo.GetStrings(1);
        var param = encounter.GetParam();
        var blank = new PK9
        {
            Species = encounter.Species,
            Form = encounter.Form
        };

        Encounter9RNG.GenerateData(blank, param, EncounterCriteria.Unrestricted, raid.Seed);
        var form = Utils.GetFormString(blank.Species, blank.Form, strings);
        var species = $"{strings.Species[encounter.Species]}";
        var rarevariant = $"{(raid.EC % 100 == 0 && (encounter!.Species == 924 || encounter.Species == 206) ? " Rare Variant" : "")}";
        var difficulty = Difficulty(encounter.Stars, raid.IsEvent, eventType);
        var nature = $"{strings.Natures[blank.Nature]}";
        var ability = $"{strings.Ability[blank.Ability]}";
        var shiny = Shiny(
            raid.CheckIsShiny(encounter),
            ShinyExtensions.IsSquareShinyExist(blank),
            eventType
        );
        var gender = GenderEmoji(blank.Gender, eventType);
        var teratype = raid.GetTeraType(encounter);
        var tera = $"{strings.types[teratype]}";
        var teraemoji = TeraEmoji(strings.types[teratype], eventType);
        var ivs = IVsStringEmoji(ToSpeedLast(blank.IVs), eventType);
        var perfectIvCount = blank.IVs.Count(iv => iv == 31);
        var moves = new ushort[4]
        {
                encounter.Move1,
                encounter.Move2,
                encounter.Move3,
                encounter.Move4
        };
        var movestr = string.Concat(
                moves.Where(z => z != 0).Select(z => $"{strings.Move[z]}ㅤ\n")
            )
            .Trim();
        var extramoves = string.Concat(
                encounter.ExtraMoves.Where(z => z != 0).Select(z => $"{strings.Move[z]}ㅤ\n")
            )
            .Trim();
        var extramovesstr = extramoves == string.Empty ? "None" : extramoves;
        var area =
            $"{Areas.GetArea((int)(raid.Area - 1), raid.MapParent)}"
            + (_config.ToggleDen ? $" [Den {raid.Den}]ㅤ" : "ㅤ");
        var rewards = GetRewards(rewardsList, eventType);
        var scale = blank.Scale;
        var copy = $"{difficulty} {shiny} **{species}{form}** {gender} **{teraemoji}** `{PokeSizeDetailedUtil.GetSizeRating(scale)} ({scale})`\n" +
                       $"**__{perfectIvCount}__IV**: {ivs}  **Nature:** `{nature}`  **Ability:** `{ability}`\n" +
                       $"**Moves:** \n{movestr}\n" +
                       $"{(extramoves == "" ? "" : $"**Extra Moves:** \n{extramovesstr}\n")}" +
                       $"{(rewards != "" ? $"**Rewards:** {rewards}\n :" : "")}" +
                       $"***Code:*** ";
        var technicalcopy = $"{encounter.Stars},{shiny},{species},{blank.Form},{blank.Gender},{teratype},{nature},{ability},{blank.Scale},{IVsStringEmoji(ToSpeedLast(blank.IVs), "technicalcopy")}";
        var SuccessWebHook = new
        {
            username = "RaidCrawler " + _config.InstanceName,
            avatar_url = "https://www.serebii.net/scarletviolet/ribbons/mightiestmark.png",
            content = MessageContent,
            embeds = new List<object>
                {
                    new
                    {
                        title = $"{shiny} {species}{form}{rarevariant} {gender} {teraemoji}",
                        description = "",
                        color = int.Parse(hexColor, NumberStyles.HexNumber),
                        thumbnail = new
                        {
                            url = $"https://github.com/kwsch/PKHeX/blob/master/PKHeX.Drawing.PokeSprite/Resources/img/Artwork%20Pokemon%20Sprites/a{spriteName}.png?raw=true"
                            //url = raid.CheckIsShiny(encounter) ? $"https://github.com/ViolentSpatula/PokeSprite/blob/main/SmallShiny/{encounter.Species-1}{(encounter.Form != 0 ? $"-{encounter.Form}" : "")}.gif?raw=true" : $"https://github.com/kwsch/PKHeX/blob/master/PKHeX.Drawing.PokeSprite/Resources/img/Artwork%20Pokemon%20Sprites/a{spriteName}.png?raw=true"
                        },
                        fields = new List<object>
                        {
                            new { name = "Difficultyㅤㅤㅤㅤㅤㅤ", value = difficulty, inline = true, },
                            new { name = "Natureㅤㅤㅤ", value = nature, inline = true },
                            new { name = "Ability", value = ability, inline = true, },

                            new { name = "IVs", value = ivs, inline = true, },
                            new { name = "Moves", value = movestr, inline = true, },
                            new { name = "Extra Moves", value = extramoves == string.Empty ? "None" : extramoves, inline = true, },

                            new { name = "Location󠀠󠀠󠀠", value = area, inline = true, },
                            new { name = "Search Time󠀠󠀠󠀠", value = time, inline = true, },
                            new { name = "Filter Name", value = filter.Name, inline = true, },

                            new { name = rewards != "" ? "Rewards" : "", value = rewards, inline = true, },
                            new { name = "", value = "", inline = true, },
                            new { name = "Size", value = $"{PokeSizeDetailedUtil.GetSizeRating(scale)} ({scale})", inline = true, },
                        },
                    }
                }
        };
        return (eventType == "webhook" ? SuccessWebHook : eventType == "copy" ? copy : technicalcopy);
    }

    public string GetAnnouncement(ITeraRaid encounter, Raid raid, RaidFilter filter, string time, IReadOnlyList<(int, int, int)> RewardsList, string hexColor, string spriteName, string eventType)
    {
        var announcement = GenerateWebhook(encounter, raid, filter, time, RewardsList, hexColor, spriteName, eventType);

        if (announcement == null)
        {
            return "Error generating announcement.";
        }

        return announcement.ToString();
    }

    protected string Difficulty(byte stars, bool isEvent, string eventType)
    {
        bool enable = eventType == "webhook" ? _config.EnableEmoji : eventType == "copy" ? _config.CopyEmoji : false;
        string emoji = !enable ? ":star:"
                               : stars == 7 ? _config.Emoji["7 Star"]
                               : isEvent ? _config.Emoji["Event Star"]
                               : _config.Emoji["Star"];

        return string.Concat(Enumerable.Repeat(emoji, stars));
    }

    protected string GenderEmoji(int genderInt, string eventType)
    {
        string gender = string.Empty;
        bool emoji = eventType == "webhook" ? _config.EnableEmoji : eventType == "copy" ? _config.CopyEmoji : false;
        switch (genderInt)
        {
            case 0: gender = (emoji ? _config.Emoji["Male"] : "♂"); break;
            case 1: gender = (emoji ? _config.Emoji["Female"] : "♀"); break;
            case 2: gender = ""; break;
        }
        return gender;
    }

    protected string GetRewards(IReadOnlyList<(int, int, int)> rewards, string eventType)
    {
        string s = string.Empty;
        int abilitycapsule = 0;
        int bottlecap = 0;
        int abilitypatch = 0;
        int sweetherba = 0;
        int saltyherba = 0;
        int sourherba = 0;
        int bitterherba = 0;
        int spicyherba = 0;

        for (int i = 0; i < rewards.Count; i++)
        {
            switch (rewards[i].Item1)
            {
                case 0645:
                    abilitycapsule++;
                    break;
                case 0795:
                    bottlecap++;
                    break;
                case 1606:
                    abilitypatch++;
                    break;
                case 1904:
                    sweetherba++;
                    break;
                case 1905:
                    saltyherba++;
                    break;
                case 1906:
                    sourherba++;
                    break;
                case 1907:
                    bitterherba++;
                    break;
                case 1908:
                    spicyherba++;
                    break;
            }
        }

        bool emoji = eventType == "webhook" ? _config.EnableEmoji : eventType == "copy" ? _config.CopyEmoji : false;
        s += (abilitycapsule > 0) ? (emoji ? $"`{abilitycapsule}`{_config.Emoji["Ability Capsule"]} " : $"`{abilitycapsule}` Ability Capsule  ") : "";
        s += (bottlecap > 0) ? (emoji ? $"`{bottlecap}`{_config.Emoji["Bottle Cap"]} " : $"`{bottlecap}` Bottle Cap  ") : "";
        s += (abilitypatch > 0) ? (emoji ? $"`{abilitypatch}`{_config.Emoji["Ability Patch"]} " : $"`{abilitypatch}` Ability Patch  ") : "";
        s += (sweetherba > 0) ? (emoji ? $"`{sweetherba}`{_config.Emoji["Sweet Herba"]} " : $"`{sweetherba}` Sweet Herba  ") : "";
        s += (saltyherba > 0) ? (emoji ? $"`{saltyherba}`{_config.Emoji["Salty Herba"]} " : $"`{saltyherba}` Salty Herba  ") : "";
        s += (sourherba > 0) ? (emoji ? $"`{sourherba}`{_config.Emoji["Sour Herba"]} " : $"`{sourherba}` Sour Herba  ") : "";
        s += (bitterherba > 0) ? (emoji ? $"`{bitterherba}`{_config.Emoji["Bitter Herba"]} " : $"`{bitterherba}` Bitter Herba  ") : "";
        s += (spicyherba > 0) ? (emoji ? $"`{spicyherba}`{_config.Emoji["Spicy Herba"]} " : $"`{spicyherba}` Spicy Herba  ") : "";

        return s;
    }

    protected string IVsStringEmoji(int[] ivs, string eventType)
    {
        string s = string.Empty;
        string spacer = eventType == "technicalcopy" ? "," : _config.IVsSpacer;
        bool emoji = eventType == "webhook" ? _config.EnableEmoji : eventType == "copy" ? _config.CopyEmoji : false;
        bool verbose = eventType == "technicalcopy" ? false : _config.VerboseIVs;
        int IVsStyle = eventType == "technicalcopy" ? 2 : _config.IVsStyle;
        var stats = new[] { "HP", "Atk", "Def", "SpA", "SpD", "Spe" };
        var iv0 = new[]
        {
                _config.Emoji["Health 0"],
                _config.Emoji["Attack 0"],
                _config.Emoji["Defense 0"],
                _config.Emoji["SpAttack 0"],
                _config.Emoji["SpDefense 0"],
                _config.Emoji["Speed 0"]
            };
        var iv31 = new[]
        {
                _config.Emoji["Health 31"],
                _config.Emoji["Attack 31"],
                _config.Emoji["Defense 31"],
                _config.Emoji["SpAttack 31"],
                _config.Emoji["SpDefense 31"],
                _config.Emoji["Speed 31"]
            };
        for (int i = 0; i < ivs.Length; i++)
        {
            switch (IVsStyle)
            {
                case 0:
                {
                    s += ivs[i] switch
                    {
                        0
                            => emoji
                                ? $"{iv0[i]:D}{(verbose ? " " + stats[i] : string.Empty)}"
                                : $"`{"✓":D}`{(verbose ? " " + stats[i] : string.Empty)}",
                        31
                            => emoji
                                ? $"{iv31[i]:D}{(verbose ? " " + stats[i] : string.Empty)}"
                                : $"`{"✓":D}`{(verbose ? " " + stats[i] : string.Empty)}",
                        _ => $"`{ivs[i]:D}`{(verbose ? " " + stats[i] : string.Empty)}",
                    };

                    if (i < 5)
                        s += spacer;
                    break;
                }
                case 1:
                {
                    s += $"`{ivs[i]:D}`{(verbose ? " " + stats[i] : string.Empty)}";
                    if (i < 5)
                        s += spacer;
                    break;
                }
                case 2:
                {
                    s += $"{ivs[i]:D}{(verbose ? " " + stats[i] : string.Empty)}";
                    if (i < 5)
                        s += spacer;
                    break;
                }
            }
        }
        return s;
    }

    protected string Shiny(bool shiny, bool square, string eventType)
    {
        bool emoji = eventType == "webhook" ? _config.EnableEmoji : eventType == "copy" ? _config.CopyEmoji : false;
        string s = string.Empty;
        if (square && shiny)
            s = $"{(emoji ? _config.Emoji["Square Shiny"] : eventType == "technicalcopy" ? 2 : "Square shiny")}";
        else if (shiny)
            s = $"{(emoji ? _config.Emoji["Shiny"] : eventType == "technicalcopy" ? 1 : "Shiny")}";
        else
            s = $"{(eventType == "technicalcopy" ? 0 : "")}";

        return s;
    }

    protected static int[] ToSpeedLast(int[] ivs)
    {
        var res = new int[6];
        res[0] = ivs[0];
        res[1] = ivs[1];
        res[2] = ivs[2];
        res[3] = ivs[4];
        res[4] = ivs[5];
        res[5] = ivs[3];
        return res;
    }

    protected string TeraEmoji(string tera, string eventType) => eventType == "webhook" ? (_config.EnableEmoji ? _config.Emoji[tera] : tera) : eventType == "copy" ? (_config.CopyEmoji ? _config.Emoji[tera] : tera) : tera;
}

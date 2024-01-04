namespace RaidCrawler.WinForms.SubForms;

public partial class EmojiConfig : Form
{
    private readonly ClientConfig _clientConfig;

    private static readonly string[] _presetOptions = { "Base", "Vio", "Custom" };

    private static readonly Dictionary<string, string> _basePresets = new()
    {
        { "Bug", "<:bug:1064546304048496812>" },
        { "Dark", "<:dark:1064557656079085588>" },
        { "Dragon", "<:dragon:1064557631890538566>" },
        { "Electric", "<:electric:1064557559563943956>" },
        { "Fairy", "<:fairy:1064557682566123701>" },
        { "Fighting", "<:fighting:1064546289406189648>" },
        { "Fire", "<:fire:1064557482468446230>" },
        { "Flying", "<:flying:1064546291239104623>" },
        { "Ghost", "<:ghost:1064546307848536115>" },
        { "Grass", "<:grass:1064557534096130099>" },
        { "Ground", "<:ground:1064546296725241988>" },
        { "Ice", "<:ice:1064557609857863770>" },
        { "Normal", "<:normal:1064546286247886938>" },
        { "Poison", "<:poison:1064546294854586400>" },
        { "Psychic", "<:psychic:1064557585124049006>" },
        { "Rock", "<:rock:1064546299992625242>" },
        { "Steel", "<:steel:1064557443742453790>" },
        { "Water", "<:water:1064557509404270642>" },
        { "Male", "<:male:1064844611341795398>" },
        { "Female", "<:female:1064844510636552212>" },
        { "Shiny", "<:shiny:1064845915036323840>" },
        { "Square Shiny", ":white_square_button:" },
        { "Event Star", "<:bluestar:1064538604409471016>" },
        { "7 Star", "<:pinkstar:1064538642934140978>" },
        { "Star", "<:yellowstar:1064538672113922109>" },
        { "Health 0", "<:h0:1064842950573572126>" },
        { "Health 31", "<:h31:1064726680628895784>" },
        { "Attack 0", "<:a0:1064842895712075796>" },
        { "Attack 31", "<:a31:1064726668419289138>" },
        { "Defense 0", "<:b0:1064842811196833832>" },
        { "Defense 31", "<:b31:1064726671703429220>" },
        { "SpAttack 0", "<:c0:1064842749272133752>" },
        { "SpAttack 31", "<:c31:1064726673649582121>" },
        { "SpDefense 0", "<:d0:1064842668624068608>" },
        { "SpDefense 31", "<:d31:1064726677176987832>" },
        { "Speed 0", "<:s0:1064842545953243176>" },
        { "Speed 31", "<:s31:1064726682721865818>" },
        { "Sweet Herba", "<:sweetherba:1064541764163227759>" },
        { "Sour Herba", "<:sourherba:1064541770148483073>" },
        { "Salty Herba", "<:saltyherba:1064541768147796038>" },
        { "Bitter Herba", "<:bitterherba:1064541773763977256>" },
        { "Spicy Herba", "<:spicyherba:1064541776699994132>" },
        { "Bottle Cap", "<:bottlecap:1064537470370320495>" },
        { "Ability Capsule", "<:abilitycapsule:1064541406921752737>" },
        { "Ability Patch", "<:abilitypatch:1064538087763476522>" },
        { "Error", "<:exclamation:1065868106360160346>" }
    };

    private static readonly Dictionary<string, string> _vioPresets = new()
    {
        { "Bug", "<:tBug:1060235283976699995>" },
        { "Dark", "<:tDark:1060235285394366564>" },
        { "Dragon", "<:tDragon:1060235286879141917>"},
        { "Electric", "<:tElectric:1060235288691093566>"},
        { "Fairy", "<:tFairy:1060235282127003730>"},
        { "Fighting", "<:tFighting:1060235325705822309>"},
        { "Fire", "<:tFire:1060235326834102382>"},
        { "Flying", "<:tFlying:1060235328717336646>"},
        { "Ghost", "<:tGhost:1060235329665241129>"},
        { "Grass", "<:tGrass:1060235303828332655>"},
        { "Ground", "<:tGround:1060235355867058308>"},
        { "Ice", "<:tIce:1060235356710109246>"},
        { "Normal", "<:tNormal:1060235360334008331>"},
        { "Poison", "<:tPoison:1060235353732161569>"},
        { "Psychic", "<:tPsychic:1060235385235570811>"},
        { "Rock", "<:tRock:1060235386279972906>"},
        { "Steel", "<:tSteel:1060235358358491147>"},
        { "Water", "<:tWater:1060235383411056640>"},
        { "Male", "<:male:1060738367274352730>"},
        { "Female", "<:female:1060738368541048965>"},
        { "Shiny", "<:shiny:1065558448995049493>"},
        { "Square Shiny", "<:square:1065831026057814097>"},
        { "Event Star", "<:raidStarB:1060475726572294144>"},
        { "7 Star", "<:raidStarM:1060475723405606994>"},
        { "Star", "<:raidStarY:1060475725498560512>"},
        { "Health 0", "<:m1Health0:1063983356309688430>"},
        { "Health 31", "<:m1Health31:1063983357773500508>"},
        { "Attack 0", "<:m2Attack0:1063983327385751683>"},
        { "Attack 31", "<:m2Attack31:1063983329097039992>"},
        { "Defense 0", "<:m3Defence0:1063983331294838814>"},
        { "Defense 31", "<:m3Defence31:1063983333056458822>"},
        { "SpAttack 0", "<:m4SpecialAttack0:1063983360294273084>"},
        { "SpAttack 31", "<:m4SpecialAttack31:1063983361619660861>"},
        { "SpDefense 0", "<:m5SpecialDefence0:1063983385762082867>"},
        { "SpDefense 31", "<:m5SpecialDefence31:1063983387137822761>"},
        { "Speed 0", "<:m6Speed0:1063983390052847659>" },
        { "Speed 31", "<:m6Speed31:1063983441672163469>" },
        { "Sweet Herba", "<:herbaSweet:1058436152924844052>"},
        { "Sour Herba", "<:herbaSour:1058436114752475228>"},
        { "Salty Herba", "<:herbaSalty:1058436153931464764>"},
        { "Bitter Herba", "<:herbaBitter:1058436112034562088>"},
        { "Spicy Herba", "<:herbaSpicy:1058436113276096614>"},
        { "Bottle Cap", "<:bottlecap:1058436109761265765>"},
        { "Ability Capsule", "<:abilitycapsule:1059122237019537478>"},
        { "Ability Patch", "<:abilitypatch:1059123255283302450>"},
        { "Error", "<:exclamation:1065868106360160346>" }
    };

    public EmojiConfig(ClientConfig clientConfig)
    {
        _clientConfig = clientConfig;
        InitializeComponent();
        EmojiGrid.AllowUserToAddRows = false;
        EmojiGrid.AllowUserToDeleteRows = false;
        EmojiGrid.AllowUserToOrderColumns = false;
        LoadEmoji(EmojiGrid, _clientConfig.Emoji);
        EnableEmoji(EmojiGrid);
    }

    private void EmojiGrid_Changed(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
        {
            EnableEmoji(EmojiGrid);
            UpdateEmojiConfig();
        }
    }

    private void LoadEmoji(DataGridView view, Dictionary<string, string> emoji)
    {
        view.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Emoji",
            DataPropertyName = "Emoji"
        });

        var presetColumn = new DataGridViewComboBoxColumn
        {
            DataSource = _presetOptions,
            HeaderText = "Preset",
            DataPropertyName = "Preset"
        };
        view.Columns.Add(presetColumn);

        view.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Emoji Value",
            DataPropertyName = "EmojiValue"
        });

        foreach (var kvp in emoji)
        {
            var index = view.Rows.Add(kvp.Key, "Base", kvp.Value);
            EmojiToPresetSelection((DataGridViewComboBoxCell)view.Rows[index].Cells[1], kvp.Key, kvp.Value);
        }

        view.Columns[0].ReadOnly = true;
    }

    private void EmojiToPresetSelection(DataGridViewComboBoxCell cb, string key, string value)
    {
        if (_basePresets[key] == value)
        {
            cb.Value = _presetOptions[0];
        }
        else if (_vioPresets[key] == value)
        {
            cb.Value = _presetOptions[1];
        }
        else
        {
            cb.Value = _presetOptions[2];
        }
    }

    private void EnableEmoji(DataGridView view)
    {
        foreach (DataGridViewRow row in view.Rows)
        {
            var cbCell = (DataGridViewComboBoxCell)row.Cells[1];
            var valueCell = (DataGridViewTextBoxCell)row.Cells[2];

            if (cbCell.Value.ToString() == _presetOptions[2])
            {
                valueCell.ReadOnly = false;
                valueCell.Style.BackColor = Color.Empty;
            }
            else
            {
                valueCell.ReadOnly = true;
                valueCell.Style.BackColor = SystemColors.ControlDark;
            }
        }
    }

    private void UpdateEmojiConfig()
    {
        var dict = new Dictionary<string, string>();
        foreach (DataGridViewRow row in EmojiGrid.Rows)
        {
            string key = (string)row.Cells[0].Value;
            string value;

            if ((string)row.Cells[1].Value == _presetOptions[0])
            {
                value = _basePresets[key];
            }
            else if ((string)row.Cells[1].Value == _presetOptions[1])
            {
                value = _vioPresets[key];
            }
            else
            {
                value = (string)row.Cells[2].Value;
            }

            dict.Add(key, value);
        }

        _clientConfig.Emoji = dict;
    }
}

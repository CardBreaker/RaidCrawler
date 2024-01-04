using PKHeX.Core;
using RaidCrawler.Core.Interfaces;
using RaidCrawler.Core.Structures;
using SysBot.Base;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace RaidCrawler.Core.Discord;

public class FomoNotificationHandler : NotificationHandler
{
    protected override string[]? DiscordWebhooks { get { return _config.EnableFomoNotification ? _config.DiscordFomoWebhook.Split(',') : null; } }
    protected override string MessageContent { get { return string.Empty; } }

    public FomoNotificationHandler(in IWebhookConfig config) : base(in config) { }
}

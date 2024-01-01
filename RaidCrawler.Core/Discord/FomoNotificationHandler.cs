using PKHeX.Core;
using RaidCrawler.Core.Interfaces;
using RaidCrawler.Core.Structures;
using SysBot.Base;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace RaidCrawler.Core.Discord;

public class FomoNotificationHandler(IWebhookConfig config) : NotificationHandler(config)
{
    private readonly string[]? _fomoWebhooks = config.EnableFomoNotification ? config.DiscordFomoWebhook.Split(',') : null;
    protected override string[]? DiscordWebhooks { get { return _fomoWebhooks; } }
    protected override string MessageContent { get { return string.Empty; } }
}

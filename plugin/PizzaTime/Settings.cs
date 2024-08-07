using Dalamud.Configuration;
using System;

namespace PizzaTime;

[Serializable]
internal sealed class Settings : IPluginConfiguration
{
    public int Version { get; set; } = 0;

    internal bool EnableOrderStatusNotifications { get; set; } = true;
}

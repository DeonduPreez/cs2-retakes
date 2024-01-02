﻿namespace RetakesPlugin.Modules.Configs;

public class RetakesConfigData
{
    public static int CurrentVersion = 1;

    public int Version { get; set; } = 1;
    public int MaxPlayers { get; set; } = 9;
    public float TerroristRatio { get; set; } = 0.45f;
    public int RoundsToScramble { get; set; } = 5;
    public bool EnableFallbackAllocation { get; set; } = true;
}
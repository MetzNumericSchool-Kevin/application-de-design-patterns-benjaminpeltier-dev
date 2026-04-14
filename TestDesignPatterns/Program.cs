Console.WriteLine($"Current Difficulty: {SettingsManager.Instance.GameDifficulty}");
Console.WriteLine($"Current Music Volume: {SettingsManager.Instance.VolumeMusic}");
Console.WriteLine("Updating settings...");
SettingsManager.Instance.GameDifficulty = SettingsManager.Difficulty.Hard;
SettingsManager.Instance.VolumeMusic = 100;
Console.WriteLine($"Current Difficulty: {SettingsManager.Instance.GameDifficulty}");
Console.WriteLine($"Current Music Volume: {SettingsManager.Instance.VolumeMusic}");

Console.ReadLine();
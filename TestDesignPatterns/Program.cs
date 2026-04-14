/*
Console.WriteLine($"Current Difficulty: {SettingsManager.Instance.GameDifficulty}");
Console.WriteLine($"Current Music Volume: {SettingsManager.Instance.VolumeMusic}");
Console.WriteLine("Updating settings...");
SettingsManager.Instance.GameDifficulty = SettingsManager.Difficulty.Hard;
SettingsManager.Instance.VolumeMusic = 100;
Console.WriteLine($"Current Difficulty: {SettingsManager.Instance.GameDifficulty}");
Console.WriteLine($"Current Music Volume: {SettingsManager.Instance.VolumeMusic}");
*/

CharacterFactory warriorFactory = new WarriorFactory();
warriorFactory.Attack();
CharacterFactory archerFactory = new ArcherFactory();
archerFactory.Attack();
CharacterFactory mageFactory = new MageFactory();
mageFactory.Attack();

Console.ReadLine();
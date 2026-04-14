/* SINGLETON PATTERN EXAMPLE
Console.WriteLine($"Current Difficulty: {SettingsManager.Instance.GameDifficulty}");
Console.WriteLine($"Current Music Volume: {SettingsManager.Instance.VolumeMusic}");
Console.WriteLine("Updating settings...");
SettingsManager.Instance.GameDifficulty = SettingsManager.Difficulty.Hard;
SettingsManager.Instance.VolumeMusic = 100;
Console.WriteLine($"Current Difficulty: {SettingsManager.Instance.GameDifficulty}");
Console.WriteLine($"Current Music Volume: {SettingsManager.Instance.VolumeMusic}");
*/

/* FACTORY PATTERN EXAMPLE
CharacterFactory warriorFactory = new WarriorFactory();
warriorFactory.Attack();
CharacterFactory archerFactory = new ArcherFactory();
archerFactory.Attack();
CharacterFactory mageFactory = new MageFactory();
mageFactory.Attack();
*/

Console.WriteLine("=== Recruiting your party ===");
HeroBuilder heroBuilder = new HeroBuilder();
HeroDirector heroDirector = new HeroDirector(heroBuilder);

heroDirector.ConstructWarrior("Thorin Oakenshield", "Dwarf", 5);
Hero warrior = heroBuilder.GetHero();
Console.WriteLine(warrior.ToString());

heroDirector.ConstructBurglar("Bilbo Baggins", "Hobbit");
Hero burglar = heroBuilder.GetHero();
Console.WriteLine(burglar.ToString());

heroBuilder.WithName("Gandalf the Grey");
heroBuilder.WithClass("Wizard");
heroBuilder.WithRace("Maia");
heroBuilder.WithLevel(10);
heroBuilder.WithStrength(12);
heroBuilder.WithAgility(10);
heroBuilder.WithIntelligence(20);
heroBuilder.WithWeapon("Glamdring");
heroBuilder.WithArmor("Grey Hat");
heroBuilder.WithInventory(new string[] { "Staff", "Pipe", "Narya" });
heroBuilder.WithAbilities(new string[] { "Light of the dawn", "You shall not pass", "Hope" });
Hero wizard = heroBuilder.GetHero();
Console.WriteLine(wizard.ToString());
Console.WriteLine("You have recruited a party of adventurers! Prepare for your quest!");

Console.ReadLine();
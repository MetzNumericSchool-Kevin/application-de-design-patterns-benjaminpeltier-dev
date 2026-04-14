#region BUILDER
public interface IHeroBuilder
{
    public void WithName(string name);
    public void WithClass(string heroClass);
    public void WithRace(string race);
    public void WithLevel(int level);
    public void WithStrength(int strength);
    public void WithAgility(int agility);
    public void WithIntelligence(int intelligence);
    public void WithWeapon(string weapon);
    public void WithArmor(string armor);
    public void WithAbilities(string[] abilities);
    public void WithInventory(string[] inventory);
}

public class HeroBuilder : IHeroBuilder
{
    private Hero _hero = new Hero();

    public HeroBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _hero = new Hero();
    }

    public void WithAbilities(string[] abilities)
    {
        _hero.Abilities = abilities;
    }

    public void WithAgility(int agility)
    {
        _hero.Agility = agility;
    }

    public void WithArmor(string armor)
    {
        _hero.Armor = armor;
    }

    public void WithClass(string heroClass)
    {
        _hero.Class = heroClass;
    }

    public void WithIntelligence(int intelligence)
    {
        _hero.Intelligence = intelligence;
    }

    public void WithInventory(string[] inventory)
    {
        _hero.Inventory = inventory;
    }

    public void WithLevel(int level)
    {
        _hero.Level = level;
    }

    public void WithName(string name)
    {
        _hero.Name = name;
    }

    public void WithRace(string race)
    {
        _hero.Race = race;
    }

    public void WithStrength(int strength)
    {
        _hero.Strength = strength;
    }

    public void WithWeapon(string weapon)
    {
        _hero.Weapon = weapon;
    }

    public Hero GetHero()
    {
        Hero result = _hero;
        Reset();
        return result;
    }
}

public class Hero
{
    public string? Name { get; set; }
    public string? Class { get; set; }
    public string? Race { get; set; }
    public int Level { get; set; } = 1;
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public string? Weapon { get; set; }
    public string? Armor { get; set; }
    public string[]? Abilities { get; set; }
    public string[]? Inventory { get; set; }

    public override string ToString()
    {
        return $"{Name} the {Class}, level {Level}.";
    }
}
#endregion

public class HeroDirector
{
    private IHeroBuilder _builder;

    public HeroDirector(IHeroBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructWarrior(string name, string race, int level = 1)
    {
        _builder.WithName(name);
        _builder.WithClass("Warrior");
        _builder.WithRace(race);
        _builder.WithLevel(level);
        _builder.WithStrength(15);
        _builder.WithAgility(8);
        _builder.WithIntelligence(5);
        _builder.WithWeapon("Axe");
        _builder.WithArmor("Heavy Armor");
        _builder.WithAbilities(new string[] { "Cleave", "Rage" });
        _builder.WithInventory(new string[] { "Health Potion", "Throwing Axe" });
    }

    public void ConstructBurglar(string name, string race, int level = 1) {
        _builder.WithName(name);
        _builder.WithClass("Burglar");
        _builder.WithRace(race);
        _builder.WithLevel(level);
        _builder.WithStrength(5);
        _builder.WithAgility(15);
        _builder.WithIntelligence(10);
        _builder.WithWeapon("Dagger");
        _builder.WithAbilities(new string[] { "Stealth", "Riddle" });
        _builder.WithInventory(new string[] { "Health Potion", "Invisibility Ring" });
    }

}
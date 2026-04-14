#region FACTORY
public abstract class CharacterFactory
{
    abstract public IAttacker CreateAttacker();

    public void Attack()
    {
        IAttacker attacker = CreateAttacker();
        attacker.Attack();
    }
}

public class WarriorFactory : CharacterFactory
{
    public override IAttacker CreateAttacker()
    {
        return new Warrior();
    }
}

public class ArcherFactory : CharacterFactory
{
    public override IAttacker CreateAttacker()
    {
        return new Archer();
    }
}

public class MageFactory : CharacterFactory
{
    public override IAttacker CreateAttacker()
    {
        return new Mage();
    }
}
#endregion

#region CHARACTERS
public interface IAttacker
{
    void Attack();
}

public class Warrior : IAttacker
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword!");
    }
}

public class Archer : IAttacker
{
    public void Attack()
    {
        Console.WriteLine("Archer attacks with a bow!");
    }
}

public class Mage : IAttacker
{
    public void Attack()
    {
        Console.WriteLine("Mage attacks with a spell!");
    }
}
#endregion
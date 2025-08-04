namespace ChainOfResponsability;

class Goblin : Creature
{
    protected override bool CanStopHero(Hero hero)
    {
        return hero.Strength < 5;
    }
}

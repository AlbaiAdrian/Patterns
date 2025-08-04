namespace ChainOfResponsability;

class Orc : Creature
{
    protected override bool CanStopHero(Hero hero)
    {
        return hero.Strength < 10;
    }
}

namespace ChainOfResponsability;

class Dragon : Creature
{
    protected override bool CanStopHero(Hero hero)
    {
        return hero.Strength < 20;
    }
}
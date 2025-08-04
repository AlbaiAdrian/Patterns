namespace ChainOfResponsability;

// Abstract Handler
abstract class Creature
{
    protected Creature next;

    //!!!! Method to forge the CHAIN :)
    public void SetNext(Creature nextCreature)
    {
        next = nextCreature;
    }

    //!!! Request comes to the object
    public void HandleRequest(Hero hero)
    {
        if (!CanStopHero(hero))
        {
            Console.WriteLine($"{GetType().Name} lets the hero pass.");
            next?.HandleRequest(hero);
        }
        else
        {
            Console.WriteLine($"{GetType().Name} stops the hero!");
        }
    }

    // !!!!! Method to decide if the request is handled here or passed further
    protected abstract bool CanStopHero(Hero hero);
}
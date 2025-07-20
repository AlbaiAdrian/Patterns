namespace Composite;

public abstract class Component
{
    public abstract string Operation();

    // THIS BREAKS THE I FROM SOLID because it is not implemenetd in the leaf
    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    // THIS BREAKS THE I FROM SOLID because it is not implemenetd in the leaf
    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    public Component Parent { get; set; }

}

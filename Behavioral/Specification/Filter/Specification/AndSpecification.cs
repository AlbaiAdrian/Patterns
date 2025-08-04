namespace OpenCloseBookExample_I.Filter.Specification;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _firstSpec;
    private readonly ISpecification<T> _secondSpec;

    public AndSpecification(ISpecification<T> firstSpec, ISpecification<T> secondSpec)
    {
        _firstSpec = firstSpec;
        _secondSpec = secondSpec;
    }

    public bool IsSatisfied(T item)
    {
        return _firstSpec.IsSatisfied(item) && _secondSpec.IsSatisfied(item);
    }
}

namespace OpenCloseBookExample_I.Filter.Specification;

public interface ISpecification<T>
{
    bool IsSatisfied(T item);
}

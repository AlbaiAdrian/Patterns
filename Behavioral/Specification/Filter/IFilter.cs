using OpenCloseBookExample_I.Filter.Specification;

namespace OpenCloseBookExample_I.Filter;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}

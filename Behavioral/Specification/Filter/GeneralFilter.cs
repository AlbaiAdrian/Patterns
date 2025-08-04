using OpenCloseBookExample_I.Filter.Specification;

namespace OpenCloseBookExample_I.Filter;

public class GeneralFilter<T> : IFilter<T>
{
    public IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
            {
                yield return item;
            }
        }
    }
}

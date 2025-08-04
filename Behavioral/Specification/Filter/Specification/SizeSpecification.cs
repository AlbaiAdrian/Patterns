using OpenCloseBookExample_I.Entities;
using OpenCloseBookExample_I.Enums;

namespace OpenCloseBookExample_I.Filter.Specification;

public class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }
    public bool IsSatisfied(Product item)
    {
        return item.Size == _size;
    }
}

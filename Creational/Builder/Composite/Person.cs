namespace Composite;

public class Person
{
    // Address info
    public string StreetAddress, City, Postcode;

    // Job info
    public string CompanyName, Position;
    public int AnnualIncome;

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(City)}: {City}, {nameof(Postcode)}: {Postcode}\n" +
               $"{nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
    }
}

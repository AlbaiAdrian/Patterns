namespace Composite;

public class PersonBuilder
{
    protected Person _person = new Person();

    public PersonAddressBuilder Lives => new PersonAddressBuilder(_person);
    public PersonJobBuilder Works => new PersonJobBuilder(_person);

    public Person Build() => _person;
}

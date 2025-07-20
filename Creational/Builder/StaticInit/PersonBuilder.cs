using System.Runtime.InteropServices;

namespace StaticInit;

public class PersonBuilder
{
    public static PersonBuilder Create()
    {
        return new PersonBuilder();
    }

    private PersonBuilder() { }

    private Person _person = new Person();

    public PersonBuilder WithFirstName(string firstName)
    {
        _person.FirstName = firstName;
        return this;
    }

    public PersonBuilder WithLastName(string lastName)
    {
        _person.LastName = lastName;
        return this;
    }

    public PersonBuilder WithAge(int age)
    {
        _person.Age = age;
        return this;
    }

    public Person Build()
    {
        return _person;
    }
}

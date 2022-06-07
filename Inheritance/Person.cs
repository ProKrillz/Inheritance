namespace Inheritance;
public class Person {
    public string Name { get; init; }
    public byte Age { get; init; }

    public string PrintPerson()
    {
        return $"Name: {Name}\nAge: {Age}";
    }
}

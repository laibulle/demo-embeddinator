public struct Person
{
    public string FirstName { get; }

    public string LastName { get; }


    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string Greet() => $"Hello, I am {FirstName} {LastName}!";
}

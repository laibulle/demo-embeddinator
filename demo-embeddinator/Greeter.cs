using System;
using System.Threading.Tasks;
//public delegate int HandlePerson(Person person);

public static class Greeter
{
    private static Person[] persones = {
        new Person("John", "Doe"),
        new Person("Johna", "Doe"),
        new Person("Marilyn", "Monroe"),
    };

    public static Task<Person[]> Greet()
    {
        return Task.Factory.StartNew(() => {
            return persones;
        });
    }
}


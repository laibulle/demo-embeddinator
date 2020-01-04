using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Greeter
{
    private static Person[] persones = {
        new Person("John", "Doe"),
        new Person("Marilyn", "Monroe"),
        new Person("Abraham", "Lincoln"),
        new Person("Nelson", "Mandela"),
        new Person("John F.", "Kennedy"),
        new Person("Martin Luther", "King"),
        new Person("Winston", "Churchill"),
        new Person("Donald", "Trump"),
    };

    private readonly ConcurrentBag<Person> foundPersonnes = new ConcurrentBag<Person>();

    private volatile bool isFinished;

    private volatile bool isRunning;

    public bool IsFinished() => isFinished;

    /*public Person[] GetNewPersones(Person[] previous)
    {
        if (previous.Length == foundPersonnes.Count) return new Person[] { };

        var length = foundPersonnes.Count - previous.Length;
        var result = new Person[length];
        Array.Copy(foundPersonnes.ToArray(), previous.Length, result, 0, length);
        return result;
    }*/

    public Person[] GetPersones()
    {
        return foundPersonnes.ToArray();
    }

    public Person[] Greet()
    {
        if (isRunning) return null;

        isRunning = true;

        Task.Factory.StartNew(() => {
            foreach(var p in persones)
            {
                foundPersonnes.Add(p);
                Task.Delay(1000).Wait();
            }

        }).Wait();

        var res = foundPersonnes.ToArray();
        isRunning = false;
        isFinished = true;

        return res;
    }
}

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

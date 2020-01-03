using System.Threading.Tasks;
//public delegate int HandlePerson(Person person);

public static class Greeter
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

    public static Person[] Greet()
    {
        Task.Factory.StartNew(() => {
            foreach(var p in persones)
            {
                System.Console.WriteLine(p.Greet());
                Task.Delay(1000).Wait();
            }
        });

        return persones;
    }
}


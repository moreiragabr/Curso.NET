namespace Aula24;

public class Program
{
    public static void Main()
    {
        Person person = new Person()
        {
            Age = 17
        };

        Person person2 = new Person()
        {
            Age = 18
        };

        if (person.ifLegalPerson(person.Age))
        {
            Console.WriteLine("Legal.");
        }
        else
        {
            Console.WriteLine("Ilegal.");
        }

        if (person2.ifLegalPerson(person2.Age))
        {
            Console.WriteLine("Legal.");
        }
        else
        {
            Console.WriteLine("Ilegal.");
        }
    }
}
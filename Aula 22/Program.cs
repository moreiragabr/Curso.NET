using System.Data;

namespace Aula22;

public class Program
{
    public static void Main()
    {
        List<Cake> cakes = new List<Cake> { };
        Cake cake = new Cake { };
        cake.Id = 1;
        cake.Name = "bolo de molango";
        cakes.Add(cake);

        foreach (Cake cakee in cakes)
        {
            Console.WriteLine("\n" + cakee.Id + "\n" + cakee.Name);
        }
        Console.WriteLine("\n");
    }
}
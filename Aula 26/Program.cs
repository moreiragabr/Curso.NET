namespace Aula26;

public class Program
{
    public static void Main()
    {
        Cake cake = new Cake(){};

        Console.WriteLine(cake.Coverage);
        Console.WriteLine(cake.Flavor);
    }
}
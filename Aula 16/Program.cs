namespace Aula16;

public class Program
{
    public static void Main()
    {
        string[] letras = { "x", "y", "z", "j", "k" };

        Console.WriteLine("\n" + letras[0] + letras[1] + letras[2] + "\n");

        foreach (string letra in letras)
        {
            Console.WriteLine("\n" + letra + "\n");
        }

        Console.WriteLine("\n" + letras.Length + "\n");

        int[] ints = new int[3];

        foreach (int inteiro in ints)
        {
            Console.WriteLine("\n" + inteiro + "\n");
        }

        ints[0] = 1;
        ints[1] = 2;
        ints[2] = 3;

        foreach (int inteiro in ints)
        {
            Console.WriteLine("\n" + inteiro + "\n");
        }
    }
}
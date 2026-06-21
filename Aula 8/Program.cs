namespace Aula08;

public class Program()
{
    public static void Main()
    {
        Console.WriteLine("\n=-=-=-=-=Operadores relacionais=-=-=-=-=");

        Console.WriteLine("\nDigite o primeiro número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite o segundo número: ");
        int y = Convert.ToInt32(Console.ReadLine());

        string result;

        if (x == y)
        {
            result = "o primeiro é igual o segundo";

        }
        else //!=
        {
            result = "o primeiro é diferente do segundo";
        }

        Console.WriteLine("\n" + result + "\n");

        if (x >= y)
        {
            result = "o primeiro é maior ou igual que o segundo";

        }
        else //<
        {
            result = "o primeiro é menor que o segundo";
        }

        Console.WriteLine("\n" + result + "\n");
    }
}
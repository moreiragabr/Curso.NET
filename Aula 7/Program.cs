namespace Aula07;

public class Program()
{
    public static void Main()
    {
        Console.WriteLine("\n=-=-=-=-=-=Operadores de Atribuição=-=-=-=-=-=");

        int x = 10;

        Console.WriteLine("\nValor inicial de x: " + x);

        x = 20;
        Console.WriteLine("\n" + x);

        
        x++;
        Console.WriteLine("\n" + x);

        x+= 10;
        Console.WriteLine("\n" + x);

        x-= 10;
        Console.WriteLine("\n" + x);

        x*= 10;
        Console.WriteLine("\n" + x);

        Console.WriteLine("\n");
    }
}
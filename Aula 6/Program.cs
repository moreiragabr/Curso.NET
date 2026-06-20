namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("============numero par ou impar============");
        Console.WriteLine("coloca um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number % 2;

        if (result == 0)
        {
            Console.WriteLine("numero par");
        }
        else
        {
            Console.WriteLine("numero impar");
        }
    }
}
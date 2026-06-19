namespace Aula03;

public class Program
{
    public static void Main()
    {
        int number;
        number = 10;
        number = 20;
        number = 30;

        Console.WriteLine(number);

        var x = 10;
        var y = true;
        var z = "string";

        Console.WriteLine(x + ", " + y + ", " + z);

        dynamic j;
        j = 10;
        j = "string";
        j = true;

        Console.WriteLine(j);
    }
}
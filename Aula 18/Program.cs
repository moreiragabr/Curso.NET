namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText("file.txt", "ola mundinho inho");
        Console.WriteLine("arquivo criado");
    }
}
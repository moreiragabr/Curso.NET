namespace Aula17;

public class Program()
{
    public static void Main()
    {
        Console.WriteLine("\n");

        List<char> letras = new List<char>
        {
          'A',
          'B',
          'C',
          'D',
        };

        foreach (char letra in letras)
        {
            Console.WriteLine(letra);
        }

        Console.WriteLine("\n");

        letras.AddRange('E', 'F');
        letras.Add('G');

        foreach (char letra in letras)
        {
            Console.WriteLine(letra);
        }

        Console.WriteLine("\n");

        letras.Remove('G');

        foreach (char letra in letras)
        {
            Console.WriteLine(letra);
        }

        Console.WriteLine("\n");
    }
}
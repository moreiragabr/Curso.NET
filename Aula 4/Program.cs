namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-------- Login --------");

        Console.WriteLine("Digite seu nome:  ");
        string name = Console.ReadLine();

        Console.WriteLine("Digite seu nome:  ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------");
        
        Console.WriteLine("Nome digitado: " + name);
        Console.WriteLine("Idade digitada: " + age);
    }
}
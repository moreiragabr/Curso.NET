namespace Aula25;

public class Program
{
    public static void Main()
    {
        BankOperations bankOperations = new BankOperations(){};

        Console.WriteLine(bankOperations.CheckBalance());
    }
}
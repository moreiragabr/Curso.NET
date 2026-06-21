namespace Aula09;

public class Program()
{
    public static void Main()
    {
        Console.WriteLine("\n=-=-=-=-=-=Operadores Lógicos=-=-=-=-=-=");

        bool isLogged = true;
        bool isAdmin = true;

        Console.WriteLine("\nInformações do usuário:");
        Console.WriteLine("\nEstá logado?");
        if (isLogged) { Console.WriteLine("Sim"); } else { Console.WriteLine("Não"); }

        Console.WriteLine("\nÉ Admin?");
        if (isAdmin) { Console.WriteLine("Sim"); } else { Console.WriteLine("Não"); }

        if (isAdmin && isLogged)
        {
            Console.WriteLine("\nEstá logado e é admin");
        }

        Console.WriteLine("\n=-=-=-=-=-=");

        isAdmin = false;

        Console.WriteLine("\nInformações do usuário:");
        Console.WriteLine("\nEstá logado?");
        if (isLogged) { Console.WriteLine("Sim"); } else { Console.WriteLine("Não"); }

        Console.WriteLine("\nÉ Admin?");
        if (isAdmin) { Console.WriteLine("Sim"); } else { Console.WriteLine("Não"); }

        if (isAdmin || isLogged)
        {
            Console.WriteLine("\nEstá logado OU é admin");
        }

        Console.WriteLine("\n=-=-=-=-=-=");

        isLogged = false;

        Console.WriteLine("\nInformações do usuário:");

        Console.WriteLine("\nEstá logado?");
        if (isLogged) { Console.WriteLine("Sim"); } else { Console.WriteLine("Não"); }

        Console.WriteLine("\nÉ Admin?");
        if (isAdmin) { Console.WriteLine("Sim"); } else { Console.WriteLine("Não"); }

        if (!isLogged)
        {
            Console.WriteLine("\nEstá deslogado\n");
        }
    }
}
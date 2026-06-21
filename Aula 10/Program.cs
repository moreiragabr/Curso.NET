namespace Aula10;

public class Program()
{
    public static void Main()
    {

        bool varContinue = true;

        while (varContinue)
        {

            Console.WriteLine("\n=-=-=-=-=-=Calculadora simples=-=-=-=-=-=");
            Console.WriteLine("\nDigite o primeiro número: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTipo de operação:");
            Console.WriteLine("1 - Adição (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.WriteLine("\nEscolha o tipo de operação:");
            int option = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            if (option == 1)
            {
                result = x + y;
                Console.WriteLine("\nResultado: " + result);
            }

            if (option == 2)
            {
                result = x - y;
                Console.WriteLine("\nResultado: " + result);
            }

            if (option == 3)
            {
                result = x * y;
                Console.WriteLine("\nResultado: " + result);
            }

            if (option == 4)
            {
                result = x / y;
                Console.WriteLine("\nResultado: " + result);
            }

            if (option > 4 || option < 1)
            {
                Console.WriteLine("\nOpção não existente.");
            }

            Console.WriteLine("\nContinuar? (s/n)");
            string option2 = Console.ReadLine();
            if (option2 != "s") { varContinue = false; }
        }
        Console.WriteLine("\nAté mais!\n");
    }
}
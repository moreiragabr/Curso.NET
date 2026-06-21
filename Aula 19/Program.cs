namespace Aula19;

using System.Diagnostics;
using System.IO;

public class Program()
{
    public static void Main()
    {
        string path = @"C:\Users\gabri\Documents\Projetos.NET\Curso.NET\Aula 19\";
        string fileName = "listaDeCompras.txt";
        string filePath = path + fileName;

        List<string> shopingList = new List<string>();

        if (File.Exists(filePath))
        {
            shopingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n=-=-=-=-=-=-=Lista de compras=-=-=-=-=-=-=");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Exibir lista");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");


            string choice = Console.ReadLine();
            string item = "";

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nInsira o nome do item a ser inserido: ");
                    item = Console.ReadLine();
                    if (!string.IsNullOrEmpty(item))
                    {
                        shopingList.Add(item);
                        Console.WriteLine("Item adicionado!");
                    }
                    else
                    {
                        Console.WriteLine("Item vazio!");
                    }
                    break;

                case "2":
                    Console.WriteLine("\nInsira o nome do item a ser removido: ");
                    item = Console.ReadLine();
                    if (!string.IsNullOrEmpty(item))
                    {
                        if (shopingList.Remove(item))
                        {
                            Console.WriteLine("Item removido!");
                        }
                        else
                        {
                            Console.WriteLine("Item não encontrado!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Item vazio!");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nLista de itens:\n");
                    foreach (string itemm in shopingList)
                    {
                        Console.WriteLine(itemm);
                    }
                    Console.WriteLine("\n");
                    break;

                case "4":
                    File.WriteAllLines(filePath, shopingList);
                    Console.WriteLine("\nLista salva!");
                    Console.WriteLine("\nSaindo...\n");
                    return;
            }

        }
    }
}
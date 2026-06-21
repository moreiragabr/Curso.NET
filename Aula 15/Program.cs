namespace Aula15;

public class Program
{
    public static void Main()
    {
        List<int> numberList = new List<int>(){1,1,1,1,1,1,1,1,1,1};
        int i = 0;

        foreach(int number in numberList)
        {
            i+=number;
            Console.WriteLine(i);
        }
    }
}
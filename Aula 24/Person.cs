namespace Aula24;

public class Person
{
    public long Id;
    public string Name;
    public int Age;

    public bool ifLegalPerson(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

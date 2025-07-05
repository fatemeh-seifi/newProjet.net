//تعریف کلاس 
public class Test1
{
    public int Age;
    public string Name;
    public bool Accept;
    public Test1(int age, string name, bool accept)
    {
        Age = age;
        Name = name;
        Accept = accept;
    }
    public void printData(string person)
    {
        Console.WriteLine($"Hi I'm {person} my age is {Age} my name is {Name}");
    }
}


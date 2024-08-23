namespace InheritanceDemoCSharp_50;

public class Person
{
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    //Method
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}!");
    }
}
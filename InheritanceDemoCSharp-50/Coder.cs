namespace InheritanceDemoCSharp_50;

public class Coder : Person
{
    public string ProgrammingLanguage { get; set; }

    public void Code()
    {
        Console.WriteLine($"I can code in {ProgrammingLanguage}!");
    }
}
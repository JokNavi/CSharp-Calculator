namespace CSharpCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("what's your name? ");
        Console.Write("My name is: ");
        string userName = AskInput("Bob");
        Console.WriteLine(userName);
    }
    public static string AskInput(string defaultValue)
    {
        string? input = Console.ReadLine();
        return String.IsNullOrEmpty(input) ? defaultValue : input;
    }
}


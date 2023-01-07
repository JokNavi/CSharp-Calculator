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

    /*
     * Takes an input and returns a default value if empty.
     * 
     * @param {defaultValue} The default value. 
     * @returns {input} OR defaultValue if empty.
     */
    public static string AskInput(string defaultValue = "Unknown")
    {
        string? input = Console.ReadLine();
        return String.IsNullOrEmpty(input) ? defaultValue : input;
    }
}


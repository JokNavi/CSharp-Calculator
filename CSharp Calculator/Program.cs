namespace CSharpCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Number objNumber = new Number();
        Console.WriteLine(objNumber.numberString);
        Level objLevel = new Level(0);
        Console.WriteLine(objLevel.depth);
    }

}

internal class Calculate
{

}
internal class SplitInput
{

}

internal class Number
{
    internal string numberString = "";
    internal bool isFloat => this.numberString.Contains('.');
    internal bool isNegative => this.numberString.Contains('-');

}

internal class Level
{
    internal List<string> levelContents = new List<string>();
    internal int depth;
    internal Level(int depth) { this.depth = depth; }
}
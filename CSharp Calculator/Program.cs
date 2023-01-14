namespace CSharp_Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter your equation: ");
            string input = Console.ReadLine();
            //validateInput
            CreateNumbers createGroups = new CreateNumbers(input);
            List<string> numberGroups = createGroups.CreateNumberGroups();
            Console.WriteLine($"[{string.Join(", ", numberGroups)}]");

        }
    }
}
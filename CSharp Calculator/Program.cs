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
            Console.WriteLine($"NumberGroups: [{string.Join(", ", numberGroups)}]");

            CreateLayers createLayers = new CreateLayers(numberGroups);
            List<object> layerGroups = createLayers.CreateLayersGroups();
            Console.WriteLine($"layerGroups: [{string.Join(", ", layerGroups)}]");

            ProcessLayers processLayers = new ProcessLayers();
            processLayers.ProcessAllLayers(layerGroups);
        }
    }
}
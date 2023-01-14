namespace CSharp_Calculator
{
    internal class ProcessLayers
    {
        private bool reachedBottom = false;

        internal float ProcessAllLayers(List<object> inputList)
        {

            for (int i = 0; i < inputList.Count; i++)
            {
                
                if (!inputList.OfType<List<object>>().Any())
                {
                    Console.WriteLine("Bottom reached!");
                    Console.WriteLine(inputList);
                    reachedBottom = true;
                    Console.WriteLine(inputList[i]);
                    return 0;
                }
                else if (inputList[i] is List<object>)
                {
                    ProcessAllLayers((List<object>)inputList[i]);
                }
                
            }
            return 0;
        }
    }

}
namespace CSharp_Calculator
{
    internal class ProcessLayers
    {
        internal string ProcessAllLayers(List<object> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
               if (inputList[i] is List<object>)
                {
                    inputList[i] = ProcessAllLayers((List<object>)inputList[i]);
                }
            }
            if (!inputList.OfType<List<object>>().Any())
            {
                return ProcessLayer(inputList);
            }
            return "0";
        }
        internal string ProcessLayer(List<object> inputList)
        {
            foreach (object item in inputList)
            {
                Console.WriteLine(item.ToString());
            }
            return "0";
        }
    }

}
namespace CSharp_Calculator
{
    internal class ProcessLayers
    {

        internal float ProcessAllLayers(List<object> inputList)
        {
            if (!inputList.OfType<List<object>>().Any()) 
            {
                
                return ProcessLayer(inputList);
            }
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] is List<object>)
                {
                    inputList[i] = ProcessAllLayers((List<object>)inputList[i]);
                }
                                
            }
            return 0;
        }
        internal float ProcessLayer(List<object> inputList)
        {
            foreach (object item in inputList)
            {
                Console.WriteLine(item.ToString());
            }
            return 0;
        }
    }

}
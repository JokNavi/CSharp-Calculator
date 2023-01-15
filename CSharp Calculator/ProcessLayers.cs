namespace CSharp_Calculator
{
    internal class ProcessLayers
    {
        internal string ProcessAllLayers(List<object> inputList)
        {
            // check if input list is empty, return default value or throw error
            if (inputList.Count == 0)
            {
                return "0";
            }
            // iterate over all elements of the input list
            for (int i = 0; i < inputList.Count; i++)
            {
                // check if the current element is a sublist
                if (inputList[i] is List<object>)
                {
                    // recursively process the sublist
                    inputList[i] = ProcessAllLayers((List<object>)inputList[i]);
                }
            }
            // check if the input list doesn't contain any more sublists 
            if (!inputList.OfType<List<object>>().Any())
            {
                // process current list 
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
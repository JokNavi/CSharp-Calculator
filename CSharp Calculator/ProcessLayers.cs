namespace CSharp_Calculator
{
    internal class ProcessLayers
    {
        internal string ProcessAllLayers(List<object> inputList)
        {
            WorkoutLayer workoutLayer = new WorkoutLayer();

            for (int i = 0; i < inputList.Count; i++)
            {
               if (inputList[i] is List<object>)
                {
                    inputList[i] = ProcessAllLayers((List<object>)inputList[i]);
                }
            }
            if (!inputList.OfType<List<object>>().Any())
            {
                return workoutLayer.WorkOut(inputList);
            }
            return "0";
        }
        
    }

}
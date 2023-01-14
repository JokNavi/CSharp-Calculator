namespace CSharp_Calculator
{
    internal class CreateLayers
    {
        private List<object> currentLayer;
        internal CreateLayers(List<string> input) => currentLayer = new List<object>(input);

        internal List<object> CreateLayersGroups()
        {
            int openBracketAmount = currentLayer.Count(s => s.ToString().Contains("("));

            List<object> tempList;

            for (int i = 0; i < openBracketAmount; i++)
            {
                int firstOpenBracketIndex = currentLayer.FindIndex(a => a.ToString().Contains("("));
                int lastClosedBracketIndex = currentLayer.FindLastIndex(a => a.ToString().Contains(")"));

                tempList = new List<object>();
                tempList = currentLayer.GetRange(firstOpenBracketIndex + 1, lastClosedBracketIndex - firstOpenBracketIndex - 1);

                currentLayer.RemoveRange(firstOpenBracketIndex, lastClosedBracketIndex - firstOpenBracketIndex + 1);
                currentLayer.Insert(firstOpenBracketIndex, tempList);
            }
            return currentLayer;
        }
    }
}


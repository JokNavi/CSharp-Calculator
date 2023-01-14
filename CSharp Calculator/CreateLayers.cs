namespace CSharp_Calculator
{
    internal class CreateLayers
    {
        private List<object> finalEquation;
        private List<object> currentLayer;
        internal CreateLayers(List<string> input) => currentLayer = new List<object>(input);

        internal List<object> CreateLayersGroups()
        {
            if (!currentLayer.Contains("(")) { finalEquation = new List<object>(); return finalEquation; }

            for (int i = 0; i < currentLayer.Count; i++)
            {
                int firstOpenBracketIndex = currentLayer.FindIndex(a => (string)a == "(");
                int lastClosedBracketIndex = currentLayer.FindLastIndex(a => (string)a == ")");
                List<object> tempList = currentLayer.GetRange(firstOpenBracketIndex, lastClosedBracketIndex - firstOpenBracketIndex + 1);
                currentLayer.RemoveRange(firstOpenBracketIndex, lastClosedBracketIndex - firstOpenBracketIndex + 1);
                currentLayer.Insert(firstOpenBracketIndex, tempList);
            }
            
            return finalEquation;
        }
    }
}

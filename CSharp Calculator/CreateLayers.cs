namespace CSharp_Calculator
{
    internal class CreateLayers
    {
        private List<object> finalEquation = new List<object>();
        private List<object> currentLayer;
        internal CreateLayers(List<string> input) => currentLayer = new List<object>(input);

        internal List<object> CreateLayersGroups()
        {
            int firstOpenBracketIndex = 0;
            int lastClosedBracketIndex = 0;
            if (!currentLayer.Contains("(")) { return finalEquation; }

            for (int i = 0; i < currentLayer.Count; i++)
            {
                firstOpenBracketIndex = currentLayer.FindIndex(a => (string)a == "(");
                lastClosedBracketIndex = currentLayer.FindLastIndex(a => (string)a == ")");
            }
            return finalEquation;
        }
    }
}

using System.Security;

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
                int openBracketIndex = currentLayer.FindLastIndex(a => a.ToString().Contains("("));
                int closedBracketIndex = currentLayer.GetRange(openBracketIndex, currentLayer.Count - openBracketIndex).FindIndex(a => a.ToString().Contains(")"))+openBracketIndex;

                tempList = new List<object>();
                tempList = currentLayer.GetRange(openBracketIndex, closedBracketIndex - openBracketIndex+1);

                currentLayer.RemoveRange(openBracketIndex, closedBracketIndex - openBracketIndex+1);
                currentLayer.Insert(openBracketIndex, tempList);
            }
            return currentLayer;
        }

    }
}


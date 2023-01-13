namespace CSharp_Calculator
{
    internal class SplitLayers
    {
        private protected LayerCollection finalEquation;
        private protected LayerCollection currentLayer;
        internal SplitLayers(LayerCollection inputLayer)
        {
            this.currentLayer = inputLayer;
        }

        /*
         * Transforms an input equation into a LayerColletion object with Layers as seperate nested lists.
         * 
         * @version: 2.0
         * 
         * @returns {finalEquation} LayerCollection object with corrently nested layer objects.
         */
        internal LayerCollection SplitEquation()
        {
            int openBracketAmount = currentLayer.layerContent.Count(s => s.tokenString.Contains("("));

            LayerCollection tempLayer;

            for (int i = 0; i < openBracketAmount; i++)
            {
                int firstOpenBracketIndex = currentLayer.layerContent.FindIndex(a => a.tokenString.Contains("("));
                int lastClosedBracketIndex = currentLayer.layerContent.FindLastIndex(a => a.tokenString.Contains(")"));

                tempLayer = new LayerCollection(i);
                tempLayer.layerContent = currentLayer.layerContent.GetRange(firstOpenBracketIndex + 1, lastClosedBracketIndex - firstOpenBracketIndex - 1);

                currentLayer.layerContent.RemoveRange(firstOpenBracketIndex, lastClosedBracketIndex - firstOpenBracketIndex + 1);
                currentLayer.layerContent.Insert(firstOpenBracketIndex, tempLayer);
            }

            return currentLayer;
        }

    }
}

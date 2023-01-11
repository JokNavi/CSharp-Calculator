namespace CSharp_Calculator
{
    internal class SplitLayers
    {
        private protected LayerCollection finalEquation;
        private protected LayerCollection currentLayer;
        private protected LayerCollection inputLayer;

        internal SplitLayers(LayerCollection inputLayer)
        {
            this.inputLayer = inputLayer;
        }
        /*
         * Transforms an input equation into a LayerColletion object with Layers as seperate nested lists.
         * 
         * @version: 0.1
         * 
         * @returns {finalEquation} LayerCollection object with corrently nested layer objects.
         */
        internal LayerCollection SplitEquation()
        {
            Console.WriteLine("/TODO");

            return this.finalEquation;
        }

    }
}

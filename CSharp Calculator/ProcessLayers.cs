namespace CSharp_Calculator
{
    internal class ProccessLayer
    {
        public void LoopOverLayerCollection(LayerCollection layerCollection)
        {
            if (layerCollection.layerContent.OfType<LayerCollection>().Any())
            {
                foreach (iToken item in layerCollection.layerContent)
                {
                    if (item is LayerCollection)
                    {
                        // recursively call this method for nested LayerCollection objects
                        LoopOverLayerCollection((LayerCollection)item);
                    }
                }
            }
            // CalculateSimpleExpression simpleExpression = new CalculateSimpleExpression
        }
    }
}

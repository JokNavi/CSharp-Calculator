namespace CSharp_Calculator
{
    internal class Calculate
    {
        internal double workOutLayer(LayerCollection layer)
        {
            string currentOperator = "+";
            double finalEqation = 0;
            LayerCollection filteredLayer = new LayerCollection(0);

            filteredLayer = filterLayer(layer, "+");
            return finalEqation;
        }
        static internal LayerCollection filterLayer(LayerCollection layer, string filter)
        {
            LayerCollection newLayer = new LayerCollection(0);
            newLayer.layerContent = new List<iToken>(new iToken[layer.layerContent.Count]);

            for (int i = 0; i < layer.layerContent.Count; i++)
            {
                if (i > 0 && layer.layerContent[i].tokenString == filter)
                {
                    int numberToLeft = layer.layerContent.GetRange(0, i).FindLastIndex(a => a is NumberInfo);
                    int numberToRight = layer.layerContent.GetRange(i, layer.layerContent.Count - i).FindIndex(a => a is NumberInfo) + i;

                    for (int b = numberToLeft; b <= numberToRight; b++)
                    {
                        newLayer.layerContent[b] = layer.layerContent[b];
                    }

                }
            }
            return layer;
        }

    }
}

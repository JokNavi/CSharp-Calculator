namespace CSharp_Calculator
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Testing();
            Calculator();
        }

        private static void Calculator()
        {
            LayerCollection layerSplitEquation;
            Console.Write("Please input your calculation: ");
            string? inputEquation = Console.ReadLine();
            if (String.IsNullOrEmpty(inputEquation)) { Console.WriteLine("Equation is empty."); return; }
            else
            {
                SplitLayers splitLayers = new(inputEquation);
                layerSplitEquation = splitLayers.SplitEquation();
            }
            //Console.WriteLine(string.Join(',', layerSplitEquation.layerContent));
        }

        private static void Testing()
        {
            Console.WriteLine("Hello, World!");
            NumberInfo number = new NumberInfo("5");
            Console.WriteLine(number.numberString);
            LayerCollection layer = new LayerCollection(0);
            Console.WriteLine(layer.depth);
        }
    }

    /*
    * iToken interface used to make LayerCollection be able to hold 2 types: OperatorInfo and NumberInfo.
    * 
    * @version: 1.0
    * 
    * @constructor {iToken}
    */
    internal interface iToken { }

    /*
    * OperatorInfo constructor used to give Operators an object type.
    * 
    * @version: 1.0
    * 
    * @constructor {OperatorInfo}
    */
    internal class OperatorInfo : iToken
    {
        internal string operatorString = "";
        internal bool isLayerSeparator => this.operatorString.Contains('(') || this.operatorString.Contains(')');
        internal OperatorInfo(string operatorString) { this.operatorString = operatorString; }
    }

    /*
    * LayerCollection constructor used for keeping track of a number's properties.
    * 
    * @version: 2.0
    * 
    * @constructor {NumberCollection}
    */
    internal class NumberInfo : iToken
    {
        internal string numberString = "";
        internal NumberInfo(string numberString) { this.numberString = numberString; }
        internal bool isFloat => this.numberString.Contains('.');
        internal bool isNegative => this.numberString.Contains('-');

    }
    /*
    * LayerCollection constructor used for keeping track of nested levels
    * 
    * @version: 2.0
    * 
    * @constructor {LayerCollection}
    */
    internal class LayerCollection
    {
        internal List<iToken> layerContent = new List<iToken>();
        internal int depth;
        internal LayerCollection(int depth) { this.depth = depth; }
    }


}
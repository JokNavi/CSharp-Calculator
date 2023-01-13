namespace CSharp_Calculator
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator();
            
        }

        private static void Calculator()
        {
            Console.Write("Please input your calculation: ");
            string? inputEquation = Console.ReadLine();
            if (String.IsNullOrEmpty(inputEquation)) { Console.WriteLine("Equation is empty."); return; }

            InputStringToTokens inputStringToTokens = new InputStringToTokens(inputEquation);
            LayerCollection convertedEquation = inputStringToTokens.TokeniseEquation();
            //Console.WriteLine(string.Join(',', convertedEquation.layerContent));

            SplitLayers splitLayers = new SplitLayers(convertedEquation);
            convertedEquation = splitLayers.SplitEquation();
            Console.WriteLine("Done");
        }
    }

    /*
    * iToken interface used to make LayerCollection be able to hold 2 types: OperatorInfo and NumberInfo.
    * 
    * @version: 1.0
    * 
    * @constructor {iToken}
    */
    internal interface iToken
    {
        public string tokenString
        {
            get;
            set;
        }
    }

    /*
    * OperatorInfo constructor used to give Operators an object type.
    * 
    * @version: 1.0
    * 
    * @constructor {OperatorInfo}
    */
    internal class OperatorInfo : iToken
    {
        internal string _tokenString = "";
        public string tokenString
        {
            get => _tokenString;
            set => _tokenString = value;
        }
        internal bool isLayerSeparator => this.tokenString.Contains('(') || this.tokenString.Contains(')');
        internal OperatorInfo(string operatorString) { this.tokenString = operatorString; }
    }

    /*
    * LayerCollection constructor used for keeping track of a number's properties.
    * 
    * @version: 2.1
    * 
    * @constructor {NumberCollection}
    */
    internal class NumberInfo : iToken
    {
        internal string _tokenString = "";
        public string tokenString
        {
            get => _tokenString;
            set => _tokenString = value;
        }
        internal NumberInfo(string inputString) { this.tokenString = inputString; }
        internal bool isFloat => this.tokenString.Contains('.');

    }
    /*
    * LayerCollection constructor used for keeping track of nested levels
    * 
    * @version: 2.0
    * 
    * @constructor {LayerCollection}
    */
    internal class LayerCollection : iToken
    {

        internal string _tokenString = "";
        public string tokenString
        {
            get => _tokenString;
            set => _tokenString = value;
        }

        internal List<iToken> layerContent = new List<iToken>();
        internal int depth;
        internal LayerCollection(int depth) { this.depth = depth; }
    }


}
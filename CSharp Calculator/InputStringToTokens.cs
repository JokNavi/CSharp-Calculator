namespace CSharp_Calculator
{
    internal class InputStringToTokens
    {
        private protected NumberInfo currentNumber = new NumberInfo("");
        private protected OperatorInfo currentOperator;
        private protected List<string> inputEquation;
        private protected LayerCollection finalEquation = new LayerCollection(0);
        private protected string numberString => string.Join(',', currentNumber.ToString());
        internal InputStringToTokens(string inputString)
        {
            this.inputEquation = inputString.ToCharArray().Select(c => c.ToString()).ToList();
        }

        /*
        * TokeniseEquation(): Returns a list of LayerCollection type. Stores operators and numbers in different object types under the same interface.
        * 
        * @version: 1.0
        * 
        * @returns: {this.finalEquation}: LayerCollection
        *  
        */
        internal LayerCollection TokeniseEquation()
        {
            bool isAppended = false;
            foreach (string currentCharacter in this.inputEquation)
            {

                if (isNumeric(currentCharacter) || currentCharacter == ".")
                {
                    this.currentNumber.tokenString += currentCharacter;
                    isAppended = true;
                }
                else
                {
                    if (isAppended) { this.finalEquation.layerContent.Add(this.currentNumber); }
                    this.currentNumber = new NumberInfo("");
                    this.finalEquation.layerContent.Add(new OperatorInfo(currentCharacter));
                    isAppended = false;
                }

            }
            if (isAppended) { this.finalEquation.layerContent.Add(this.currentNumber); }
            return this.finalEquation;
        }

        /*
        * IsNumeric(): Returns if a string is a floating point number or not.
        * 
        * @version: 1.0
        * 
        * @returns: {Bool}
        *  
        * @param: {s}: To be tested number in string form.
        * 
        * @private
        */
        private static bool isNumeric(string s) => int.TryParse(s, out _);
    }
}

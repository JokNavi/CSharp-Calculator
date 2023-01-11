namespace CSharp_Calculator
{
    internal class InputStringToTokens
    {
        private protected NumberInfo currentNumber;
        private protected OperatorInfo currentOperator;
        private protected List<char> inputEquation;
        private protected LayerCollection finalEquation;
        private protected string numberString => string.Join(',', currentNumber.ToString());
        internal InputStringToTokens(string inputString)
        {
            this.inputEquation = inputString.ToCharArray().ToList();
        }

        internal LayerCollection TokeniseEquation()
        {
            Console.WriteLine("/TODO");

            return this.finalEquation;
        }
    }
}

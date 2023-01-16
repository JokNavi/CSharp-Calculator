namespace CSharp_Calculator
{
    internal class CreateNumbers
    {
        private List<string> finalEquation = new List<string>();
        private List<string> inputEquation;
        private string currentNumber = "";
        private bool appended = false;
        internal CreateNumbers(string inputEquationString) => inputEquation = inputEquationString.Select(c => c.ToString()).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

        internal List<string> CreateNumberGroups()
        {
            for (int i = 0; i < inputEquation.Count; i++)
            {
                if (StringIsNumber(inputEquation[i]) || ((appended == false && finalEquation.LastOrDefault() != ")") && (inputEquation[i] == "+" || inputEquation[i] == "-") && i != inputEquation.Count && StringIsNumber(inputEquation[i+1])) || (i != 0 && inputEquation[i] == "," && StringIsNumber(inputEquation[i - 1])))
                {
                    Console.WriteLine($"Appended: {inputEquation[i]}");
                    currentNumber += inputEquation[i];
                    appended = true;
                }
                else 
                {
                    Console.WriteLine($"Pushed: {inputEquation[i]}");
                    if (appended) { finalEquation.Add(currentNumber); currentNumber = ""; }
                    finalEquation.Add(inputEquation[i]);
                    appended = false;
                }
            }
            if (appended) { finalEquation.Add(currentNumber); currentNumber = ""; }
            return finalEquation;
        }

        static private bool StringIsNumber(string i) => double.TryParse(i, out _);

    }
}

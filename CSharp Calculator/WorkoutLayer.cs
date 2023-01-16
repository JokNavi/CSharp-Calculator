using System.Text.RegularExpressions;

namespace CSharp_Calculator
{
    internal class WorkoutLayer
    {
        private List<object> FilterOperators = new List<object>();
        internal WorkoutLayer()
        {
            FilterOperators.Add(new List<object>() { "^" });
            FilterOperators.Add(new List<object>() { "*", "/" });
            FilterOperators.Add(new List<object>() { "+", "-" });
        }
        internal string WorkOut(List<object> input)
        {
            string equationAnswer = "";
            foreach (List<object> filter in FilterOperators)
            {
                int i = 0;
                Console.WriteLine($"Filter: {string.Join(",", filter)}");
                while (i < input.Count)
                {
                    string currentToken = input[i].ToString();
                    if (filter.Contains(currentToken.Substring(0, 1)) && i > 0)
                    {

                    }
                    i++;
                }
            }
            return equationAnswer;
        }
        private string DoOperator(float NumOne, float NumTwo, string Operator)
        {
            switch (Operator)
            {
                case "^":
                    return Math.Pow(NumOne, NumTwo).ToString();
                case "*":
                    return (NumOne * NumTwo).ToString();
                case "/":
                    return (NumOne / NumTwo).ToString();
                case "+":
                    return (NumOne + NumTwo).ToString();
                case "-":
                    return (NumOne - NumTwo).ToString();
                default:
                    return "-1";
            }
        }

    }
}

using System.Globalization;

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
                for (int i = 0; i < input.Count; i++)
                {
                    if (filter.Contains(input[i]))
                    {
                        float NumOne = Convert.ToSingle(input[i - 1]);
                        float NumTwo = Convert.ToSingle(input[i + 1]);
                        equationAnswer = DoOperator(NumOne, NumTwo, (string)input[i]);
                        input.RemoveRange(i - 1, i + 1);
                        input.Insert(i-1, equationAnswer);
                        i = 0;
                    }
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

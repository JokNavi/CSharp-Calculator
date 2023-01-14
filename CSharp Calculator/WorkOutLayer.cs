using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Calculator
{
    internal class WorkOutLayer
    {
        private List<object> inputList;
        internal WorkOutLayer(List<object> input) { inputList = input; }

        internal float ProcessLayer()
        {
            foreach (object item in inputList) 
            {
                Console.WriteLine(item.ToString());
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Calculator
{
    internal class FilterLayer
    {
        private List<Object> filter;
        private List<Object> finalEquation = new List<Object>();
        internal FilterLayer(List<Object> inputFilter) => filter = inputFilter;

        internal List<object> Filter()
        {
            return finalEquation;
        }

    }
}

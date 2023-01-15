using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Calculator
{
    internal class WorkoutLayer
    {
        private List<object> FilterOperators = new List<object>();
        internal WorkoutLayer() 
        {
            FilterOperators.Add(new List<object>() {"^"});
            FilterOperators.Add(new List<object>() {"*", "/"});
            FilterOperators.Add(new List<object>() { "+", "-" });
        }
        internal string WorkOut(List<object> input)
        { 
            foreach (List<object> filter in FilterOperators) 
            {    
                FilterLayer filterLayers = new FilterLayer(filter);
                List<object> filteredList = filterLayers.Filter();

            }
            return "0";
        }
    }
}

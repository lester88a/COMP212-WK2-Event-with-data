using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventWithData
{
    class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
        //there is a default constructor if you don't difinde any constructor
    }
}

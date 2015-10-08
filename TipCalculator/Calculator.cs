using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class Calculator
    {
        public decimal FirstNumber { set; private get; }
        public int TipPercent { set; private get; }
        public decimal Result { private set; get; }

        public void CalculateTip()
        {
            Result = (FirstNumber * TipPercent) / 100;
        }
    }
}

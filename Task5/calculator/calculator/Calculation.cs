using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculation : ICalculation
    {
        public int Sum(List<int> args)
        {
            return args.Sum();
        }
    }
}

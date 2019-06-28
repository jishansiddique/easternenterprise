using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculation : ICalculation
    {
        public int MultiPly(List<int> args)
        {
            return args.Aggregate(1, (a, b) => a * b);
        }
    }
}

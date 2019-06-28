using System.Collections.Generic;
using System.Linq;

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

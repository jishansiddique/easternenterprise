using System.Collections.Generic;
using System.Linq;

namespace CalcProgram
{
    public class Calculation : ICalculation
    {
        public int Sum(List<int> args)
        {
            return args.Sum();
        }
    }
}

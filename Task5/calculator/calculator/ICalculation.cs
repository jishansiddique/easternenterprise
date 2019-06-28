using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public interface ICalculation
    {
        int Sum(List<int> args);
    }
}

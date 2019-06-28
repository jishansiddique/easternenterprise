using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidator _validator = new Validator(); ;
            ICalculation _calculation = new Calculation(); ;
            List<string> argsList = new List<string>(args);
            var status = _validator.CheckInput(argsList);
            if (status.IsValid == false)
            {
                Console.WriteLine(status.Message);
            }
            else
            {
                int[] intValues;
                string[] strValues = { };
                string[] stringSeparators = new string[] { "\\", ",", ";", "\\n" };
                strValues = args.Length > 1 ? args[1].Split(stringSeparators, StringSplitOptions.None).Where(x=>!string.IsNullOrEmpty(x)).ToArray() : strValues;
                intValues = Array.ConvertAll(strValues, s => int.Parse(s));
                Console.WriteLine(_calculation.MultiPly(intValues.ToList()));
            }
            Console.ReadLine();
        }
    }
}

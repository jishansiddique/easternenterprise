using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcProgram
{
    public class Calculator
    {
     
        public static void Main(string[] args)
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
                strValues = args.Length > 1 ? args[1].Split(',') : strValues;
                intValues = Array.ConvertAll(strValues, s => int.Parse(s));
                Console.WriteLine(_calculation.Sum(intValues.ToList()));
            }
            Console.ReadLine();
        }
    }
}

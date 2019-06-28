using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;


namespace CalcProgram
{
    public class Validator : IValidator
    {
        readonly static string OperationName = Convert.ToString(ConfigurationManager.AppSettings["OperationName"]);
        InputStaus status;
        public Validator()
        {
            status = new InputStaus();
        }
        public InputStaus CheckInput(List<string> args)
        {
            if (args.Count == 0)
            {
                status.IsValid = false;
                status.Message = "Please enter a argument";
            }
            else if (args.Count == 1)
            {
                if (args[0] != OperationName)
                {
                    status.IsValid = false;
                    status.Message = "Invalid Argument";
                }
            }
            else if (args.Count == 2)
            {
                var values = args[1].Split(',').ToList();
                if (values.Count == 2 && values.TrueForAll(IsInteger))
                    status.IsValid = true;
                else
                {
                    status.IsValid = false;
                    if (values.Count > 2)
                        status.Message = "Addition of two numbers is only allowed";
                    else
                        status.Message = "Please enter nmeric values";
                }
            }
            else
            {
                status.IsValid = false;
                status.Message = "No More Arguments Allowed";
            }
            return status;
        }
        private bool IsInteger(string arg)
        {
            int num;
            return int.TryParse(arg, out num);
        }
    }
   
}

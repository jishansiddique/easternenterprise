using System.Collections.Generic;

namespace CalcProgram
{
    public interface IValidator
    {
        InputStaus CheckInput(List<string> args);
    }
}

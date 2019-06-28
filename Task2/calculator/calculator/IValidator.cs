using System.Collections.Generic;
namespace calculator
{
    public interface IValidator
    {
        InputStaus CheckInput(List<string> args);
    }
}

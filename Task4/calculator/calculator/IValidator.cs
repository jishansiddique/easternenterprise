﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public interface IValidator
    {
        InputStaus CheckInput(List<string> args);
    }
}

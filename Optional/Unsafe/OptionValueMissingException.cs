﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Optional.Unsafe
{
    public class OptionValueMissingException : Exception
    {
        internal OptionValueMissingException()
            : base()
        {
        }

        internal OptionValueMissingException(string message)
            : base(message)
        {
        }
    }
}

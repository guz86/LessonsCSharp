﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultImplementationOfTheInterface
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);
    }
}

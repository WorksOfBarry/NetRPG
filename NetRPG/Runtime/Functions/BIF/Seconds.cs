using System;
using System.Collections.Generic;
using System.Text;

namespace NetRPG.Runtime.Functions.BIF
{
    class Seconds : Function
    {
        public override object Execute(object[] Parameters)
        {
            if (Parameters[0] is int) {
              return Convert.ToInt32(Parameters[0]);
            } else {
                Error.ThrowRuntimeError("%Seconds", "Requires integer parameter.");
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using NetRPG.Runtime.Typing;
using NetRPG.Runtime.Typing.Files;

namespace NetRPG.Runtime.Functions.Operation
{
    [RPGFunctionAlias("%EOF")]
    class EndOfFile : Function
    {
        public override object Execute(object[] Parameters)
        {
            if (Parameters[0] is FileT)
            {
                FileT rla = Parameters[0] as FileT;
                return (rla.isEOF() ? "1" : "0");
            }
            else
            {
                Error.ThrowRuntimeError("%EOF", "Table or display is required.");
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windowcoder
{
    static class FishErrors
    {
        
        public class Functions_tobe_developed_Error : Exception
        {
            public Functions_tobe_developed_Error() { }
            public Functions_tobe_developed_Error (string message) : base(message) { }
            public Functions_tobe_developed_Error(string message, Exception inner) : base(message, inner) { }
            public override string Message
            {
                get
                {
                    return base.Message;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GinsbergPluginComponent
{
    public sealed class ManagedCalls
    {
        public static string GetAnswer() 
        { 
            return "The answer is 42."; 
        }

        public int SampleProperty { get; set; }
    }
}

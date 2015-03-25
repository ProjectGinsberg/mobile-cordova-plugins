using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GinsbergPluginComponent
{
    public sealed class ManagedCalls
    {
        public static void ExitApp() 
        {
            System.Diagnostics.Debug.WriteLine("ExitApp Start");
            //Application.Current.Exit();
            //Application.exit(0);
            //Windows.UI.Xaml.Application.Exit();
            //Environment.Exit(0);
            //Application.Current.Shutdown();
            System.Diagnostics.Debug.WriteLine("ExitApp End");
        }

        public int SampleProperty { get; set; }
    }
}

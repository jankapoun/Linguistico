using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Linguistico.NET_Mobile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            try
            {
                Application.Run(new MainWnd(true));
                
            }
            catch (Exception e) 
            {
                Application.Run(new MainWnd(false));
            }
            
        }
    }
}
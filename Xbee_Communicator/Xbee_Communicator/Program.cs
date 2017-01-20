using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xbee_Communicator
{
    
    static class Program
    {

        public static XbeeControlForm Xbee;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Xbee = new XbeeControlForm();

            Application.Run(Xbee);
       
        }

        
    }
}

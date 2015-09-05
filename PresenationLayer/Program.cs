using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Principal;

namespace BIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /**
             * This functionality will check application in running on the pc then nobody will start my application again 
             * thats why I need to check my application procress id or my application name in task manager.. 
             */

            //System.Diagnostics.Process CurrentPro = new System.Diagnostics.Process();
            //CurrentPro = System.Diagnostics.Process.GetCurrentProcess();
            //MessageBox.Show(CurrentPro.Id.ToString());


            /**
             * Get current username
             * The reason to prefer WindowsIdentity.GetCurrent() is that this returns the account that the application is running as. 
             * This is not necessarily the account that is currently logged into Windows (think "RunAs" or impersonation/delegation). 
             * So, if you want to know the logged-in user, use the Environment (if you trust it). 
             * If you want to know the security context your application is running as, using WindowsIdentity.GetCurrent(). 
             */
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //MessageBox.Show(userName.ToString());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            //Application.Run(new BIT.Account.frmLogin());
        }
    }
}



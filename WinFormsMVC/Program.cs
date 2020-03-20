using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate a new userinfo model in controller
            UserInfo info = new UserInfo();

            // instantiate form1
            var form1 = new FirstForm();
            // controller interact w/ model
            // form1 can getUserInfo or setUserInfo
            form1.UserInfo = info;
            // controller interact w/ view
            form1.ShowDialog();

            var form2 = new View.SecondForm();
            form2.UserInfo = info;
            form2.ShowDialog();


            Application.Run(new FirstForm());
        }
    }
}

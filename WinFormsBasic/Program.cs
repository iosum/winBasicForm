using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new MyForm();
            // will cause the application.run to exit
            form.FormClosed += (s, e) => Application.Exit();



            // show the windows form
            form.Show();



            // when the form close, the console still running
            // continue to accept the input from the user
            Application.Run();
        }
    }
}

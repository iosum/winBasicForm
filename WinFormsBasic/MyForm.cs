using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBasic
{
    // Inheriting from class Form
    class MyForm : Form
    {
        // constructor of MyForm
        public MyForm()
        {
            var btn = new Button();
            btn.Text = "Click Me!";

            // form has a property called Controls
            // button inherit from Controls
            // this meaning the current object(MyForm)
            this.Controls.Add(btn);
            // 40 down from the form
            btn.Top = 40;
            // add an event handler to the event
            // there is a click event on the button
            // handler will be invoke, and form.close
            btn.Click += (s, e) => this.Close();
        }
    }
}

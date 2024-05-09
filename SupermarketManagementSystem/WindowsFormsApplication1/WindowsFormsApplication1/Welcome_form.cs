using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Welcome_form : Form
    {
        public Welcome_form()
        {
            InitializeComponent();
        }

        private void Sign_Up_Button_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            Sign_Up_Form form = new Sign_Up_Form();
            form.Show();
        }

        private void Sign_in_Button_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            FormSignIn form = new FormSignIn();
            form.Show();
          

        }
    }
}

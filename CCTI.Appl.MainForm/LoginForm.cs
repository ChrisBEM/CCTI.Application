using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTI.Appl.MainForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            uxUserName.Clear();
            uxPassword.Clear();
            uxUserName.Focus();
        }

        private void uxLogin_Click(object sender, EventArgs e)
        {
            if (uxUserName.Text == "ADMIN" && uxPassword.Text == "CPRG254")
            {
                PresentationForm prstationFrm = new PresentationForm();
                prstationFrm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password or User Name. Try Again");
                uxUserName.Clear();
                uxPassword.Clear();
                uxUserName.Focus();
            }
               

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

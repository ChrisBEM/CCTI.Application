using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCTI.DataAccessTier;

namespace CCTI.Appl.MainForm
{
    public partial class PresentationForm : Form
    {
        public PresentationForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.BringToFront();
            //loginform.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrationManager.Instance.SaveAll();
        }
    }
}

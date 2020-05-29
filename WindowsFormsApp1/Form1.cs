using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void welcomeButton_Click(object sender, EventArgs e)
        {
            String openKey = loginBox.Text;
            String privateKey = passwordBox.Text;

            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "openKey", openKey },
                { "privateKey", privateKey }
            };

            User user = new User();
            user.Authorize(data, this);
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            RegForm makeForm = new RegForm();
            makeForm.Show();
            this.Hide();
            return;
        }
        private void buttonUnknown_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ViewList(this, null);
            return;
        }
    }
}

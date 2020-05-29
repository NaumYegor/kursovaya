using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class RegForm : Form
    {
        readonly MatchCollection matches;
        public RegForm()
        {
            InitializeComponent();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "firstName", fNameBox.Text },
                { "middleName", mNameBox.Text },
                { "lName", thNameBox.Text },
                { "score1", score1Box.Text },
                { "score2", score2Box.Text },
                { "score3", score3Box.Text }
            };

            User user = new User (data);
            if (!user.Validate(user.UserData))
            {
                return;
            }

            user.MakeNewUser(user.UserData, this);

            return;
        }


        private void buttonContinue_Click(object sender, EventArgs e)
        {
            welcomeForm continueForm = new welcomeForm();
            continueForm.Show();
            this.Hide();
            return;
        }
    }
}

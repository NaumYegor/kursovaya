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
        MatchCollection matches;
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("firstName", fNameBox.Text);
            data.Add("middleName", mNameBox.Text);
            data.Add("lName", thNameBox.Text);
            data.Add("score1", score1Box.Text);
            data.Add("score2", score2Box.Text);
            data.Add("score3", score3Box.Text);

            User user = new User (data);
            if (!user.Validate(user.UserData))
            {
                return;
            }

            user.MakeNewUser(user.UserData, this);

            return;
        }

        private bool Validate(string data, Regex regexp, string type)
        {
            if (data.Length < 1) return false;
            matches = regexp.Matches(data);
            if (matches.Count != data.Length)
            {
                MessageBox.Show($"{data}\nWrong data!");
                return false;
            }
            if (type == "Score" && Convert.ToInt32(data) > 200)
            {
                MessageBox.Show($"{data}\nWrong data!");
                return false;
            }
            return true;
        }

        static Random random = new Random();
        public static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
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

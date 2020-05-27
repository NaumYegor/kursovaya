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
            Regex regexNames = new Regex("[А-я]");
            Regex regexScores = new Regex("[0-9]");
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("firstName", fNameBox.Text);
            data.Add("middleName", mNameBox.Text);
            data.Add("lName", thNameBox.Text);
            data.Add("score1", score1Box.Text);
            data.Add("score2", score2Box.Text);
            data.Add("score3", score3Box.Text);
            foreach (KeyValuePair<string, string> kvp in data) {
                if (kvp.Key.StartsWith("score"))
                {
                    if (!Validate(kvp.Value, regexScores, "Score")) return;
                } else
                {
                    if (!Validate(kvp.Value, regexNames, "Name")) return;
                }
            }

            string openKey = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            string privateKey = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            string insertionCommand = "INSERT into `users` (`fName`, `mName`, `lName`," +
                                       " `Score1`, `Score2`, `Score3`, `account`," +
                                       " `openKey`, `privateKey`)" +
                                       " VALUES (@f, @m, @l, @s1, @s2, @s3, @a, @o, @p)";
            Console.WriteLine(insertionCommand);

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(insertionCommand, db.getConnection());
            command.Parameters.Add("@f", MySqlDbType.VarChar).Value = data["firstName"];
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = data["middleName"];
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = data["lName"];
            command.Parameters.Add("@s1", MySqlDbType.Int16).Value = data["score1"];
            command.Parameters.Add("@s2", MySqlDbType.Int16).Value = data["score2"];
            command.Parameters.Add("@s3", MySqlDbType.Int16).Value = data["score3"];
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = "user";
            command.Parameters.Add("@o", MySqlDbType.VarChar).Value = openKey;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = privateKey;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ok");
                OpenKeyBox.Text = openKey;
                privateKeyBox.Text = privateKey;
            } else
            {
                MessageBox.Show("Не получилось создать.");
            }

            db.closeConnection();
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

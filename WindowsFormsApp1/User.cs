using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace WindowsFormsApp1
{
    class User
    {

      
        private MatchCollection matches;
        readonly Regex regexNames = new Regex("[А-я]");
        readonly Regex regexScores = new Regex("[0-9]");

        public User()
        {

        }

        public bool Authorize (Dictionary<string, string> data, Form thisForm)
        {

            string openKey = data["openKey"];
            string privateKey = data["privateKey"];
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `openKey` = @oKey AND `privateKey` = @pKey", db.getConnection());
            command.Parameters.Add("@oKey", MySqlDbType.VarChar).Value = openKey;
            command.Parameters.Add("@pKey", MySqlDbType.VarChar).Value = privateKey;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][6].Equals("admin"))
                {
                    AddSpecialization form = new AddSpecialization();
                    form.Show();
                    thisForm.Hide();
                    return true;
                }
                this.ViewList(thisForm, openKey);
                return true;
            }
            else MessageBox.Show("NO");
            return false;
        }

        public void MakeNewUser(Dictionary<string, string> data, RegForm form)
        {
            string openKey = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            string privateKey = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            string insertionCommand = "INSERT into `users` (`fName`, `mName`, `lName`," +
                                       " `Score1`, `Score2`, `Score3`, `account`," +
                                       " `openKey`, `privateKey`)" +
                                       " VALUES (@f, @m, @l, @s1, @s2, @s3, @a, @o, @p)";

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
                form.OpenKeyBox.Text = openKey;
                form.privateKeyBox.Text = privateKey;
            }
            else
            {
                MessageBox.Show("Не получилось создать.");
            }

            db.closeConnection();
            return;
        }

        public bool Validate(Dictionary<string, string> data)
        {
            foreach (KeyValuePair<string, string> kvp in data)
            {
                if (kvp.Key.StartsWith("score"))
                {
                    if (!RegexCheck(kvp.Value, regexScores, "Score")) return false;
                }
                else
                {
                    if (!RegexCheck(kvp.Value, regexNames, "Name")) return false;
                }
            }
            return true;
        }

        private bool RegexCheck(string data, Regex regexp, string type)
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

        public void ViewList(Form form, string openKey)
        {
            form.Hide();
            MainView view = new MainView(openKey);
            view.Show();
        }
        public void ViewApplicants(Form form)
        {
            form.Hide();
        }

        override public string ToString()
        {
            return "User";
        }

        virtual public string GetID()
        {
            return null;
        }

    }
}

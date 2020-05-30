using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace WindowsFormsApp1
{
    class Specialization
    {
        public Dictionary<string, string> Info { get; private set; }

        public Specialization()
        {
            Info = new Dictionary<string, string>
            {
                { "City", "" },
                { "School", "" },
                { "Faculty", "" },
                { "Specialization", "" },
                { "Type", "" },
                { "Price", "" }
            };
        }

        public void SetData(string name, string data)
        {
            if (!Info.ContainsKey(name))
                throw new Exception("This key does not exist.");
            Info[name] = data;
            return;
        }

        public bool ValidatePrice()
        {
            if (Info["Price"].Length<1)
            {
                MessageBox.Show("There is no Price");
                return false;
            }
            Regex regex = new Regex("[0-9]");
            if (regex.Matches(Info["Price"]).Count== Info["Price"].Length)
            {
                if (Convert.ToInt32(Info["Price"]) > 0)
                    return true;
            }

            MessageBox.Show("Странная цена");
            return false;
        }

        public bool ValidateStrings()
        {
            Regex regex = new Regex("[А-я]");
            foreach (KeyValuePair<string, string> kvp in Info)
            {
                if (Info[kvp.Key].Length < 1)
                {
                    MessageBox.Show($"{kvp.Key} is empty, set it!");
                    return false;
                }
                if (regex.Matches(Info[kvp.Key]).Count != Info[kvp.Key].Length && kvp.Key!="Price")
                {
                    MessageBox.Show($"Только кириллица : {kvp.Key}:{kvp.Value}");
                    return false;
                }
            }
            return true;
        }

        public void AddToDb()
        {
            if (!(ValidatePrice() && ValidateStrings()))
            {
                MessageBox.Show("Странные данные.");
                return;
            }

            string insertionCommand = "INSERT INTO `specializations` (`id`, `City`, `School`, `Faculty`," +
                " `Specialization`, `StudyType`, `Price`) VALUES (NULL, @City, @School, @Faculty," +
                                      " @Specialization, @StudyType, @Price)";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(insertionCommand, db.getConnection());
            command.Parameters.Add("@City", MySqlDbType.VarChar).Value = Info["City"];
            command.Parameters.Add("@School", MySqlDbType.VarChar).Value = Info["School"];
            command.Parameters.Add("@Faculty", MySqlDbType.VarChar).Value = Info["Faculty"];
            command.Parameters.Add("@Specialization", MySqlDbType.VarChar).Value = Info["Specialization"];
            command.Parameters.Add("@StudyType", MySqlDbType.VarChar).Value = Info["Type"];
            command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = Info["Price"];

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ok");
                
            }
            else
            {
                MessageBox.Show("Проблемы с базой.");
            }

            db.closeConnection();
        }

        public ListViewItem[] AllAdded()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `specializations`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);


            ListViewItem[] answer = new ListViewItem[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow data = table.Rows[i];
                string[] row = {
                    data.Field<Int32>("id").ToString(),
                    data.Field<String>("City"),
                    data.Field<String>("School"),
                    data.Field<String>("Faculty"),
                    data.Field<String>("Specialization"),
                    data.Field<String>("StudyType"),
                    data.Field<Int32>("Price").ToString(),
                };
                answer[i] = new ListViewItem(row);
            }
            return answer;
        }
    }
}

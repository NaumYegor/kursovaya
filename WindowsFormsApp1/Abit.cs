using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Abit : User
    {
        public string OpenKey { get; private set; }

        public Abit (string key)
        {
            OpenKey = key;
        }

        public override string ToString()
        {
            return "Abit";
        }

        override public string GetID()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id FROM `users` WHERE `openKey` = @openKey", db.getConnection());
            command.Parameters.Add("@openKey", MySqlDbType.VarChar).Value = OpenKey;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                string id = row[0].ToString();
                if (row.IsNull("id"))
                    MessageBox.Show("Id is Null");
                return row[0].ToString();
            } else
                throw new Exception($"Unreal open key: {OpenKey}");
            
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ApplicationReq
    {

        public string SpecializationId { get; private set; }
        public string ApplicantId { get; private set; }

        public ApplicationReq(string specId, string applId)
        {
            SpecializationId = specId;
            ApplicantId = applId;
        }

        public void AddApplication()
        {
            if (CheckPresence())
            {
                MessageBox.Show("Было уже добавлено!");
                return;
            }

            string insertionCommand = "INSERT into `applications` (`id`, `specializationId`, `userId`)" +
                                       " VALUES (NULL, @specId, @applId)";
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(insertionCommand, db.getConnection());
            command.Parameters.Add("@specId", MySqlDbType.Int32).Value = SpecializationId;
            command.Parameters.Add("@applId", MySqlDbType.Int32).Value = ApplicantId;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавили");
            }
            else
            {
                MessageBox.Show("Проблема с базой");
            }

            db.closeConnection();
            return;
        }

        public bool CheckPresence()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `applications` WHERE `specializationId` = @specId AND `userId` = @userId", db.getConnection());
            command.Parameters.Add("@userId", MySqlDbType.Int32).Value = Convert.ToInt32(ApplicantId);
            command.Parameters.Add("@specId", MySqlDbType.Int32).Value = Convert.ToInt32(SpecializationId);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        public ListViewItem[] ListById()
        {
            DB db = new DB();
            DataTable tableUserIDs = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT userId FROM `applications` WHERE `specializationId` = @specId", db.getConnection());
            command.Parameters.Add("@specId", MySqlDbType.Int32).Value = Convert.ToInt32(SpecializationId);

            adapter.SelectCommand = command;
            adapter.Fill(tableUserIDs);
            ListViewItem[] answer = new ListViewItem[tableUserIDs.Rows.Count];

            for (int i=0; i<tableUserIDs.Rows.Count; i++)
            {
                User user = new User();
                answer[i] = user.GetById(tableUserIDs.Rows[i].Field<Int32>("userId"));
            }

            return answer;
        }
    }
}

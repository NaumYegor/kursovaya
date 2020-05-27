using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class User
    {

        public User()
        {

        }

        private void MakeNewUser(Dictionary<string, string> data, RegForm form)
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
        }

    }
}

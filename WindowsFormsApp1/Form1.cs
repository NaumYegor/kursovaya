using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                MessageBox.Show("YES");
            }
            else MessageBox.Show("NO");
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            RegForm makeForm = new RegForm();
            makeForm.Show();
            this.Hide();
            return;
        }

    }
}

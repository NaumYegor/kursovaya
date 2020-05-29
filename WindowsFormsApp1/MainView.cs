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
    public partial class MainView : Form
    {
        User user;
        public MainView(string openKey)
        {
            if (openKey == null)
            {
                user = new User();
            }
            else
                user = new Abit(openKey);
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `specializations`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i=0; i<table.Rows.Count; i++)
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
                SpecializationsView.Items.Add(new ListViewItem(row));
            }
            return;
        }

        private void showContent_Click(object sender, EventArgs e)
        {
            if (SpecializationsView.SelectedItems.Count==0)
            {
                MessageBox.Show("Вы не выбрали поле!");
                return;
            }

            MessageBox.Show(SpecializationsView.SelectedItems[0].SubItems[0].Text);
            Information form = new Information();
            form.Show();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (SpecializationsView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали поле!");
                return;
            }
            if (user.ToString() == "User")
            {
                MessageBox.Show("Нужно было войти в систему!");
                return;
            }
            string selectedId = SpecializationsView.SelectedItems[0].SubItems[0].Text;
            string userId = user.GetID().ToString();
            ApplicationReq application = new ApplicationReq(selectedId, userId);
            application.AddApplication();
        }
    }
}

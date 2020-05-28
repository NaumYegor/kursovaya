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
        public MainView()
        {
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

            string[] row = { "Очко", "Очки", "Тапочки" };

            listView1.Items.Add(new ListViewItem(row));
            return;
        }

        private void showContent_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Сасать баяцца");
                return;
            }

            MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            Information form = new Information();
            form.Show();
        }
    }
}

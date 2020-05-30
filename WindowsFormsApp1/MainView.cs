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
            Specialization specialization = new Specialization();
            SpecializationsView.Items.AddRange(specialization.AllAdded());
            return;
        }

        private void showContent_Click(object sender, EventArgs e)
        {
            if (SpecializationsView.SelectedItems.Count==0)
            {
                MessageBox.Show("Вы не выбрали поле!");
                return;
            }
            string specId = SpecializationsView.SelectedItems[0].SubItems[0].Text;
            Information form = new Information(specId);
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

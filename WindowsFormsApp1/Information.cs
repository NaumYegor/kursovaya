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
    public partial class Information : Form
    {

        public string SpecializationId;
        public Information(string specId)
        {
            SpecializationId = specId;
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            ApplicationReq application = new ApplicationReq(SpecializationId, null);
            DetailListView.Items.AddRange(application.ListById());
            return;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

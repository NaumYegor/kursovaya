using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddSpecialization : Form
    {
        public AddSpecialization()
        {
            InitializeComponent();
        }

        private void MakeSpecButton_Click(object sender, EventArgs e)
        {
            Specialization specialization = new Specialization();
            specialization.SetData("City", CityBox.Text);
            specialization.SetData("School", SchoolBox.Text);
            specialization.SetData("Faculty", FacultyBox.Text);
            specialization.SetData("Specialization", SpecializationBox.Text);
            specialization.SetData("Type", TypeBox.Text);
            specialization.SetData("Price", PriceBox.Text);

            specialization.AddToDb();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            new welcomeForm().Show();
        }

        private void AddSpecialization_Load(object sender, EventArgs e)
        {

        }
    }
}

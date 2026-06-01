using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_1
{
    public partial class doctor2_form : Form
    {
        public doctor2_form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doctor2_form_Load(object sender, EventArgs e)
        {
           
            this.patientsTableAdapter.Fill(this.clinic_management_systemDataSet.Patients);

          //dataviewgrid use kia ha admin ko data show krwana ka lia 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            dataGridView1.ScrollBars = ScrollBars.Both;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
        }
    }
}

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
    public partial class doctor_patient : Form
    {
        public doctor_patient()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            doctor_patient d = new doctor_patient();
            d.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void doctor_patient_Load(object sender, EventArgs e)
        {

        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}

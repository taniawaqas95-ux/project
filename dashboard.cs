using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doctor
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            
        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor= System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;


            panel1.Visible = true;
        }

        private void btnAddhistory_Click(object sender, EventArgs e)
        {
            labelIndecator3.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
        }

        private void btnhospital_Click(object sender, EventArgs e)
        {
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String addtress = txtAddress.Text;
            Int64 contact = Convert.ToInt64(txtContact.Text);
            int age = Convert.ToInt32(txtAge.Text);
            String gender = comboGender.Text;
            String blood = txtBlood.Text;
            String any = txtAny.Text;
            int pid = Convert.ToInt32(txtpi.Text);
        }
    }
}
//in design Name we declare its type in which input is to be taken 
//when we use button we write in its design view as btn save


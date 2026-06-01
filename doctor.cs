using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace form_1
{
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void doctor_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Your information has been saved ");
                String PatientName = txtpatientName.Text;
                //String PatientID = txtPatientID.Text;
                String Age = txtAge.Text;
                String Gender = cmbGender.Text;
                String Contactnumber = txtContactNumber.Text;
                String anyseriousdisease = cmbdisease.Text;
                String Bloodgroup = cmbBloodGroup.Text;
                String Assigneddoctor = cmbassignddoctor.Text;
                String Email = txtemail.Text;
                String Diagnosis = cmbDiagnosis.Text;
                String Address = txtAddress.Text;
                String Visitingdate = dateTimePicker1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-1P4JQS7\\SQLEXPRESS;database = Clinic_management_system; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Patients values ('" + PatientName + "'," + Age + ",'" + Gender + "','" + Contactnumber + "','" + anyseriousdisease + "','" + Bloodgroup + "','" + Assigneddoctor + "','" + Email + "','" + Diagnosis + "','" + Address + "','" + Visitingdate + "')";
                //'" + PatientID + "'

                //SqlDataAdapter DA = new SqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //DA.Fill(DS);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Saved");
            }

            //doctor2_form  d2 = new doctor2_form();
            //d2.Show();






        }

        private void txtcontactnumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_1
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = txtUsername.Text;
            String Password = txtPassword.Text;
            //MessageBox.Show("your account has been successfully created");
            //account a = new account();
            //a.Show();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-1P4JQS7\\SQLEXPRESS;database = Clinic_management_system;integrated security = True";

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "insert into PatientLogin values ('" + Username + "','" + Password + "')";
            //cmd2.ExecuteNonQuery();

            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Account created successfully!");

            doctor_patient d = new doctor_patient();
            d.Show();
            doctor pID = new doctor();
            pID.Show();

        }
    }
}

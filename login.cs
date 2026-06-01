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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            String Username = txtUser.Text;
            String password = txtPass.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-1P4JQS7\\SQLEXPRESS;database = Clinic_management_system;integrated security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM PatientLogin WHERE Username = '" + Username + "' AND Password = '" + password + "'";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            con.Open();
            DA.Fill(DS);
            con.Close();

            if (Username == "jimin" && password == "jimin")
            {
                MessageBox.Show("You have successfully logged in");
                this.Hide();
                doctor2_form dc2 = new doctor2_form();
                dc2.Show();
            }


            if (DS.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Welcome back!");
                //doctor2_form d2f = new doctor2_form();
                //d2f.Show();

                doctor dc = new doctor();
                dc.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password or if you don't have an account click NEXT");
            }
        }





            //if (Username. == "user" && Password == "Password")
            //{
            //    MessageBox.Show("You have successfully login in ");
            // }
        //    if (Username == "jimin" && password == "jimin")
        //    {
        //        MessageBox.Show("You have successfully logged in");
        //        this.Hide();
        //        doctor2_form dc2 = new doctor2_form();
        //        dc2.Show();
        //    }
        //}
                //dashboard ds = new dashboard();
                //ds.Show();
                //doctor dc = new doctor();
                //dc.Show();


            //    doctor2_form d2f = new doctor2_form();
            //    d2f.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect username or password or if you don't have an account  click NEXT");
            //}
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            account a = new account();
            a.Show();

        }
    }
    }


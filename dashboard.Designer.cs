namespace doctor
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.btnAddpatient = new System.Windows.Forms.Button();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.btnAddhistory = new System.Windows.Forms.Button();
            this.btnhospital = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelIndecator1 = new System.Windows.Forms.Label();
            this.labelIndecator2 = new System.Windows.Forms.Label();
            this.labelIndecator3 = new System.Windows.Forms.Label();
            this.labelIndecator4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.txtAny = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ang = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddpatient.Location = new System.Drawing.Point(61, 102);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(177, 37);
            this.btnAddpatient.TabIndex = 0;
            this.btnAddpatient.Text = "Add new Patient Record";
            this.btnAddpatient.UseVisualStyleBackColor = false;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddDiagnosis.Location = new System.Drawing.Point(61, 145);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(177, 37);
            this.btnAddDiagnosis.TabIndex = 1;
            this.btnAddDiagnosis.Text = "Add Diagnosis Information";
            this.btnAddDiagnosis.UseVisualStyleBackColor = false;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddhistory
            // 
            this.btnAddhistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddhistory.Location = new System.Drawing.Point(61, 188);
            this.btnAddhistory.Name = "btnAddhistory";
            this.btnAddhistory.Size = new System.Drawing.Size(177, 37);
            this.btnAddhistory.TabIndex = 2;
            this.btnAddhistory.Text = "Full History of Patient";
            this.btnAddhistory.UseVisualStyleBackColor = false;
            this.btnAddhistory.Click += new System.EventHandler(this.btnAddhistory_Click);
            // 
            // btnhospital
            // 
            this.btnhospital.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhospital.Location = new System.Drawing.Point(61, 231);
            this.btnhospital.Name = "btnhospital";
            this.btnhospital.Size = new System.Drawing.Size(177, 37);
            this.btnhospital.TabIndex = 3;
            this.btnhospital.Text = "Doctor Information";
            this.btnhospital.UseVisualStyleBackColor = false;
            this.btnhospital.Click += new System.EventHandler(this.btnhospital_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTROLLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Brown;
            this.btnExit.Location = new System.Drawing.Point(61, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // labelIndecator1
            // 
            this.labelIndecator1.AutoSize = true;
            this.labelIndecator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator1.Location = new System.Drawing.Point(9, 102);
            this.labelIndecator1.Name = "labelIndecator1";
            this.labelIndecator1.Size = new System.Drawing.Size(46, 32);
            this.labelIndecator1.TabIndex = 8;
            this.labelIndecator1.Text = ">>";
            // 
            // labelIndecator2
            // 
            this.labelIndecator2.AutoSize = true;
            this.labelIndecator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator2.Location = new System.Drawing.Point(13, 145);
            this.labelIndecator2.Name = "labelIndecator2";
            this.labelIndecator2.Size = new System.Drawing.Size(46, 32);
            this.labelIndecator2.TabIndex = 9;
            this.labelIndecator2.Text = ">>";
            // 
            // labelIndecator3
            // 
            this.labelIndecator3.AutoSize = true;
            this.labelIndecator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator3.Location = new System.Drawing.Point(9, 193);
            this.labelIndecator3.Name = "labelIndecator3";
            this.labelIndecator3.Size = new System.Drawing.Size(46, 32);
            this.labelIndecator3.TabIndex = 10;
            this.labelIndecator3.Text = ">>";
            // 
            // labelIndecator4
            // 
            this.labelIndecator4.AutoSize = true;
            this.labelIndecator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator4.Location = new System.Drawing.Point(9, 236);
            this.labelIndecator4.Name = "labelIndecator4";
            this.labelIndecator4.Size = new System.Drawing.Size(46, 32);
            this.labelIndecator4.TabIndex = 11;
            this.labelIndecator4.Text = ">>";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtpi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBlood);
            this.panel1.Controls.Add(this.txtAny);
            this.panel1.Controls.Add(this.comboGender);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(252, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 394);
            this.panel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Patient Record";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Patient ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Any serious Disease suffered Earlier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Blood Group";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtpi
            // 
            this.txtpi.Location = new System.Drawing.Point(16, 350);
            this.txtpi.Name = "txtpi";
            this.txtpi.Size = new System.Drawing.Size(462, 26);
            this.txtpi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBlood
            // 
            this.txtBlood.Location = new System.Drawing.Point(233, 223);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(362, 26);
            this.txtBlood.TabIndex = 6;
            // 
            // txtAny
            // 
            this.txtAny.Location = new System.Drawing.Point(16, 288);
            this.txtAny.Name = "txtAny";
            this.txtAny.Size = new System.Drawing.Size(579, 26);
            this.txtAny.TabIndex = 5;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboGender.Location = new System.Drawing.Point(233, 187);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(362, 28);
            this.comboGender.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(233, 80);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(362, 26);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(233, 112);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(362, 26);
            this.txtContact.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(233, 149);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(362, 26);
            this.txtAge.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(233, 48);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 26);
            this.txtName.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelIndecator4);
            this.Controls.Add(this.labelIndecator3);
            this.Controls.Add(this.labelIndecator2);
            this.Controls.Add(this.labelIndecator1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhospital);
            this.Controls.Add(this.btnAddhistory);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnAddpatient);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddpatient;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnAddhistory;
        private System.Windows.Forms.Button btnhospital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelIndecator1;
        private System.Windows.Forms.Label labelIndecator2;
        private System.Windows.Forms.Label labelIndecator3;
        private System.Windows.Forms.Label labelIndecator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.TextBox txtAny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry ang;
    }
}
namespace form_1
{
    partial class doctor
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
            this.btnpatientname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpatientName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbdisease = new System.Windows.Forms.ComboBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.cmbassignddoctor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnnext = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clinic_management_systemDataSet1 = new form_1.Clinic_management_systemDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_management_systemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpatientname
            // 
            this.btnpatientname.AutoSize = true;
            this.btnpatientname.Location = new System.Drawing.Point(57, 27);
            this.btnpatientname.Name = "btnpatientname";
            this.btnpatientname.Size = new System.Drawing.Size(113, 20);
            this.btnpatientname.TabIndex = 0;
            this.btnpatientname.Text = "Patient  Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Any serious Disease";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blood group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Assigned Doctor";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtpatientName
            // 
            this.txtpatientName.Location = new System.Drawing.Point(246, 27);
            this.txtpatientName.Multiline = true;
            this.txtpatientName.Name = "txtpatientName";
            this.txtpatientName.Size = new System.Drawing.Size(373, 26);
            this.txtpatientName.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(246, 116);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(153, 26);
            this.txtAge.TabIndex = 13;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(246, 206);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(273, 26);
            this.txtContactNumber.TabIndex = 15;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtcontactnumber_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(246, 376);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(273, 26);
            this.txtemail.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(246, 467);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(523, 26);
            this.txtAddress.TabIndex = 20;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Diagnosis";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female ",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(246, 164);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(153, 28);
            this.cmbGender.TabIndex = 22;
            // 
            // cmbdisease
            // 
            this.cmbdisease.FormattingEnabled = true;
            this.cmbdisease.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbdisease.Location = new System.Drawing.Point(246, 253);
            this.cmbdisease.Name = "cmbdisease";
            this.cmbdisease.Size = new System.Drawing.Size(121, 28);
            this.cmbdisease.TabIndex = 23;
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(246, 299);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(121, 28);
            this.cmbBloodGroup.TabIndex = 24;
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Items.AddRange(new object[] {
            "High Blood Pressure ",
            "Cholesterol",
            "Headache",
            "Fever",
            "Cold ",
            "Flu",
            "Cough",
            "Sore Throat",
            "Body Pain",
            "Fatigue / Weakness",
            "Stomach Ache",
            "Diarrhea",
            "Vomiting",
            "Constipation",
            "Acidity ",
            "Heartburn",
            "Food Poisoning",
            "Asthma",
            "Tuberculosis (TB)",
            "Pneumonia"});
            this.cmbDiagnosis.Location = new System.Drawing.Point(246, 427);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(121, 28);
            this.cmbDiagnosis.TabIndex = 25;
            // 
            // cmbassignddoctor
            // 
            this.cmbassignddoctor.FormattingEnabled = true;
            this.cmbassignddoctor.Items.AddRange(new object[] {
            "Doctor 1",
            "Doctor2",
            "Doctor3"});
            this.cmbassignddoctor.Location = new System.Drawing.Point(246, 337);
            this.cmbassignddoctor.Name = "cmbassignddoctor";
            this.cmbassignddoctor.Size = new System.Drawing.Size(121, 28);
            this.cmbassignddoctor.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Visiting Date";
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(637, 253);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(149, 40);
            this.btnnext.TabIndex = 29;
            this.btnnext.Text = "SAVE";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 26);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.Value = new System.DateTime(2026, 4, 29, 0, 0, 0, 0);
            // 
            // clinic_management_systemDataSet1
            // 
            this.clinic_management_systemDataSet1.DataSetName = "Clinic_management_systemDataSet";
            this.clinic_management_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 505);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbassignddoctor);
            this.Controls.Add(this.cmbDiagnosis);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.cmbdisease);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtpatientName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpatientname);
            this.Name = "doctor";
            this.Text = "doctor";
            this.Load += new System.EventHandler(this.doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinic_management_systemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnpatientname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpatientName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbdisease;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
        private System.Windows.Forms.ComboBox cmbassignddoctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Clinic_management_systemDataSet clinic_management_systemDataSet1;
    }
}
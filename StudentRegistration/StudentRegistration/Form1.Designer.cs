namespace StudentRegistration
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_middlename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_day = new System.Windows.Forms.ComboBox();
            this.cmbx_month = new System.Windows.Forms.ComboBox();
            this.cmbx_year = new System.Windows.Forms.ComboBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_program = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name *";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(72, 96);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(200, 20);
            this.txt_lastname.TabIndex = 3;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(72, 152);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(200, 20);
            this.txt_firstname.TabIndex = 4;
            this.txt_firstname.TextChanged += new System.EventHandler(this.txt_firstname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle name *";
            // 
            // txt_middlename
            // 
            this.txt_middlename.Location = new System.Drawing.Point(72, 213);
            this.txt_middlename.Name = "txt_middlename";
            this.txt_middlename.Size = new System.Drawing.Size(200, 20);
            this.txt_middlename.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender *";
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_male.Location = new System.Drawing.Point(151, 251);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(57, 19);
            this.rbtn_male.TabIndex = 8;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_female.Location = new System.Drawing.Point(230, 253);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(72, 19);
            this.rbtn_female.TabIndex = 9;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of birth *";
            // 
            // cmbx_day
            // 
            this.cmbx_day.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_day.FormattingEnabled = true;
            this.cmbx_day.Location = new System.Drawing.Point(67, 391);
            this.cmbx_day.Name = "cmbx_day";
            this.cmbx_day.Size = new System.Drawing.Size(87, 23);
            this.cmbx_day.TabIndex = 11;
            // 
            // cmbx_month
            // 
            this.cmbx_month.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_month.FormattingEnabled = true;
            this.cmbx_month.Location = new System.Drawing.Point(160, 391);
            this.cmbx_month.Name = "cmbx_month";
            this.cmbx_month.Size = new System.Drawing.Size(87, 23);
            this.cmbx_month.TabIndex = 12;
            // 
            // cmbx_year
            // 
            this.cmbx_year.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_year.FormattingEnabled = true;
            this.cmbx_year.Location = new System.Drawing.Point(253, 391);
            this.cmbx_year.Name = "cmbx_year";
            this.cmbx_year.Size = new System.Drawing.Size(87, 23);
            this.cmbx_year.TabIndex = 13;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_register.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.Location = new System.Drawing.Point(136, 461);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(99, 41);
            this.btn_register.TabIndex = 14;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Program to apply *";
            // 
            // cbx_program
            // 
            this.cbx_program.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_program.FormattingEnabled = true;
            this.cbx_program.Location = new System.Drawing.Point(72, 319);
            this.cbx_program.Name = "cbx_program";
            this.cbx_program.Size = new System.Drawing.Size(230, 23);
            this.cbx_program.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(391, 520);
            this.Controls.Add(this.cbx_program);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.cmbx_year);
            this.Controls.Add(this.cmbx_month);
            this.Controls.Add(this.cmbx_day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_middlename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_middlename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_day;
        private System.Windows.Forms.ComboBox cmbx_month;
        private System.Windows.Forms.ComboBox cmbx_year;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_program;
    }
}


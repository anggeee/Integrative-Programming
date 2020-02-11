using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Day
            for (int day =1; day <=31; day++)
            {
                cmbx_day.Items.Add(day);
                cmbx_day.Text = "-Day-";
       
            }

            //Month
            String[] months_array = { "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"};

            foreach (String month in months_array )
            {
                cmbx_month.Items.Add(month);
                cmbx_month.Text = "-Month-";
            }

            //Year
            for (int year = 2000; year <= 2020; year++)
            {
                cmbx_year.Items.Add(year);
                cmbx_year.Text = "-Year-";

            }

            ArrayList programs = new ArrayList();

            programs.Add("Information Technology");
            programs.Add("Tourism");
            programs.Add("Culinary");
            programs.Add("Multimedia Arts");
            programs.Add("Accounting");

            foreach (String program in programs)
            {
                cbx_program.Items.Add(program);
                cbx_program.Text = "-Choose One-";
            }


        }

        String Gender;
        private void btn_register_Click(object sender, EventArgs e)
        {

            
            if (rbtn_female.Checked)
            {
                Gender = "Male";
                
            }
            else if (rbtn_male.Checked)
            {
                Gender = "Female";
            }
            MessageBox.Show("Student name: " + txt_firstname.Text + " " + txt_middlename.Text + 
                " " + txt_lastname.Text +  "\n" + "Gender:" + " " + Gender + "\n" + "Date of birth:" 
                + " " + cmbx_month.Text
                + " " + cmbx_day.Text + " " + cmbx_year.Text
                + "\n" +"Program: " + " " + cbx_program.Text);
            this.Dispose();

        }
    }
}

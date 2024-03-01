using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class StundentRegistration : Form
    {
        public StundentRegistration()
        {
            InitializeComponent();
            string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);       
            }
            
            foreach (string month in array) { 

                comboBox2.Items.Add(month);
            }

            for( int i = 1900;  i <= 2024; i++)
            {
                comboBox3.Items.Add(i);
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach(string programList in programs)
            {
                comboBox4.Items.Add(programList);
            }
        }

        private void StundetRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName, firstName, middleName;
            string gender = "";
            string program;
            lastName = textBox1.Text;
            firstName = textBox2.Text;
            middleName = textBox3.Text;

            
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\n" +
                            "Gender: " + gender + "\n" +
                            "Date of birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\n" +
                            "Program: " + comboBox4.Text);
                           

        }
    }
}

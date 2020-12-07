using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Submit(object sender, EventArgs e)
        {

            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastname.Text;
            string dateofbirth = comboBoxDay.Text + " , " + comboBoxMonth.Text + " , " + comboBoxYear.Text;
            string gender = comboBoxGander.Text;
            string email = textBoxEmail.Text;
            string securityquestion = comboBoxSecurityquestion.Text;
            string securityanswer = textBoxSecurityanswer.Text;
            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string state = comboBoxState.Text;
            string zip = textBoxZipconde.Text;
            string phone = textBoxPhone.Text;

            string output = "\nFirst name: " + firstname + "\nFLast name: " + lastname + "\nDate of birth: " + dateofbirth + "\nGenger: " + gender + "\nEmail:" + email + "\nSecurity questin: " + securityquestion + "\nSecurity answer" + securityanswer + "\nState: " + state + "\nPhone number: " + phone;
            richTextOutput.Text = output;


        }
    }
}
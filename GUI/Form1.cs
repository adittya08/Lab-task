using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login(object sender, EventArgs e)
        {
            variables obj = new variables();
            bool haserr = false;



            if (textboxUsername.Text.Equals(""))
            {
                MessageBox.Show("Username requaried");
                haserr = true;
            }
            else
            {
                obj.username = textboxUsername.Text;
            }
            if (textboxPassword.Text.Equals(""))
            {
                MessageBox.Show("Password requaried");
                haserr = true;
            }
            else
            {
                obj.password = textboxPassword.Text;
            }

            if (!haserr)
            {
                if (obj.username.Equals("adi") && obj.password.Equals("1234"))
                {

                    new Form2().Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }

        }
    }
}

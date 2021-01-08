using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginClicked(object sender, EventArgs e)
        {

            string user = Username.Text;
            string pass = Password.Text;
            string output = String.Format("User Name : {0}\nPassword : {1}", user, pass);
            if (user.Equals("Ratul Sarkar") && pass.Equals("35329"))
            {
                new Form2().Show();

            }
            else
            {
                MessageBox.Show("Invalid user name or password", "Login Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

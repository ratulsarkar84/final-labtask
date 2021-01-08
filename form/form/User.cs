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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterClick(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string gender = Gender.SelectedItem.ToString();
            string email = Email.Text;
            string reEmail = CheckEmail.Text;
            string password = Password.Text;
            string rePassword = RePassword.Text;
            string ques = securityQues.SelectedItem.ToString();
            string ans = textBox7.Text;
            string address = Address.Text;
            string city = City.Text;
            string zipCode = zip.Text;
            string phone = phoneNo.Text;
            string output = String.Format("Name : {0} {1}\nGender : {2}\nEmail : {3}\nPassword : {4}\nSecurity Question : {5}\nSecurity Answer : {6}\nAddress : {7}\nCity : {8}\nZip Code : {9}\nPhone No : {10}", firstName, lastName, gender, email, password, ques, ans, address, city, zipCode, phone);
            panel1.Visible = true;
            richTextBox1.Text = output;
        }
    }
}

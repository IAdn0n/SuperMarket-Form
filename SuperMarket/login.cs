using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private string getHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Enter UserName");
                return;
            }else if  (passwordTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Enter Password");
                return;
            }

            string userName = usernameTxtBox.Text;
            string hashedPass = getHashSha256(passwordTxtBox.Text);

            Hide();
            registerForm regForm = new registerForm();
            regForm.Show();
            
        }
    }
}

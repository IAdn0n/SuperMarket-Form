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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WindowSizes.WIDTH, Constants.WindowSizes.HEIGHT);
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


            //TODO: BASSAM DO THE DATABASE THING



            //END TODO

            //go into the main form
            MainForm mainForm = new MainForm();

            mainForm.Activate();
            mainForm.Show();

            Hide();
        }

        private void registerLblMouseEnter(object sender, EventArgs e)
        {
            RegisterLbl.ForeColor = Color.CornflowerBlue;
            RegisterLbl.Font = new Font(RegisterLbl.Font, FontStyle.Underline);
        }

        private void registerLblMouseLeave(object sender, EventArgs e)
        {
            RegisterLbl.ForeColor = Color.DodgerBlue;
            RegisterLbl.Font = new Font(RegisterLbl.Font, FontStyle.Regular);
        }

        private void registerLbl_Click(object sender, EventArgs e)
        {
            Hide();
            registerForm regForm = new registerForm(this);
            regForm.Show();
            regForm.Activate();
        }

        //hovering over buttpn
        private void loginBtnEnter(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_ENTER(loginBtn);
        }
        private void loginBtnLeave(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_LEAVE(loginBtn);
        }
    }
}

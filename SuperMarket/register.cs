using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace SuperMarket
{
    public partial class registerForm : Form
    {
        private Form previousForm;
        private bool toLogin = false;

        private const string filePath = "UsersFile.txt";
        public registerForm(Form previousLogin)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WindowSizes.WIDTH, Constants.WindowSizes.HEIGHT);


            previousForm = previousLogin;
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

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


        private void registerBtn_Click(object sender, EventArgs e)
        {
            //iput validation
            if (!checkTextBox(usernameTxtBox))
            {
                MessageBox.Show("Enter Unique Username");
                return;
            }
            else if (!checkTextBox(passwordTxtBox))
            {
                MessageBox.Show("Enter Password");
                return;
            }
            else if (!checkTextBox(confirmPasswordTxtBox))
            {
                MessageBox.Show("Confirm Password");
                return;
            }
            
            
            string userName = usernameTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();

            //if confirm password does not match password;
            if (password != confirmPasswordTxtBox.Text.Trim())
            {
                MessageBox.Show("Passwords Do Not Match");
                return;
            }
            //check UserName
            if (!checkUserName(userName))
            {
                MessageBox.Show("Username length must be less than 20\nand not contain ( , | . | whiteSpace | \' | \" | \\ )");
                return;
            }
            

            //hashing password
            password = getHashSha256(password);

            //opening a users file
            StreamReader file;
            try {
                file = File.OpenText(filePath);
            }catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            //next user id   **Sequential ID**
            int nextID = Constants.FileMethods.GetFileSize(filePath) + 1;

            //checking if username already exist
            while (!file.EndOfStream)
            {
                string user = file.ReadLine().Split(',')[1];
                if (userName == user)
                {
                    MessageBox.Show("Username already exist. try a new one");
                    file.Close();
                    return;
                }
            }
            file.Close();


            //writing users to file mechanism
            StreamWriter writer;
            try{
                writer = File.AppendText(filePath);
            }catch(Exception ex) { MessageBox.Show(ex.Message) ; return; }

            //appending new user
            writer.WriteLine(nextID.ToString() + ',' + userName + ',' + password);
            writer.Close();




            MessageBox.Show("Registration Successful");
            //going back to login form
            this.Hide();
            this.previousForm.Activate();
            this.previousForm.Show();
            
            toLogin = true;
            this.Close();
        }

        private bool checkTextBox(TextBox textBox)
        {
            return (textBox.Text == String.Empty)? false : true;
        }
        private bool checkUserName(string user)
        {
            if (user.Length > 20) return false;
            foreach (char c in user)
            {
                if (c == ',' || c == ' ' || c == '.' || c == '\\' || c == '\"' || c == '\'' || c == '\"') return false;
            }

            //everything fine
            return true;
        }

        //label hovering
        private void LblEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.CornflowerBlue;
            lbl.Font = new Font(loginLbl.Font, FontStyle.Underline);
        }

        private void LblLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.ForeColor = Color.DodgerBlue;
            lbl.Font = new Font(loginLbl.Font, FontStyle.Regular);
        }
        private void loginlbl_click(object sender, EventArgs e)
        {
            toLogin = true;
            this.Hide();
            this.previousForm.Activate();
            this.previousForm.Show();

            this.Close();
            
        }


        //hovering over buttpn
        private void registrationBtnEnter(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_ENTER(registerBtn);
        }
        private void registrationBtnLeave(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_LEAVE(registerBtn);
        }

        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!toLogin) previousForm.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class registerForm : Form
    {
        private Form previousForm;
        private bool toLogin = false;
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

               
        private void registerBtn_Click(object sender, EventArgs e)
        {

            //TODO: BASSAM DO REGISTRATION


            //TODO: END

            MessageBox.Show("Registration Successful");
            //going back to login form
            this.Hide();
            this.previousForm.Activate();
            this.previousForm.Show();

            this.Close();
        }

        //properties for going back to login in
        private void loginLblMouseEnter(object sender, EventArgs e)
        {
            loginLbl.ForeColor = Color.CornflowerBlue;
            loginLbl.Font = new Font(loginLbl.Font, FontStyle.Underline);
        }

        private void loginLblMouseLeave(object sender, EventArgs e)
        {
            loginLbl.ForeColor = Color.DodgerBlue;
            loginLbl.Font = new Font(loginLbl.Font, FontStyle.Regular);
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

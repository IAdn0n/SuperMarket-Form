﻿using System;
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
        public registerForm(Form previousLogin)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WIDTH, Constants.HEIGHT);


            previousForm = previousLogin;
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

               
        private void registerBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Registration Successful");
            //going back to login form
            Hide();
            previousForm.Activate();
            previousForm.Show();

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
            Hide();
            previousForm.Activate();
            previousForm.Show();

            this.Close();
        }

    
    }
}

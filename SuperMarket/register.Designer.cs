namespace SuperMarket
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Username:";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(363, 150);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(451, 38);
            this.usernameTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password:";
            // 
            // confirmPasswordTxtBox
            // 
            this.confirmPasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTxtBox.Location = new System.Drawing.Point(363, 279);
            this.confirmPasswordTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordTxtBox.Name = "confirmPasswordTxtBox";
            this.confirmPasswordTxtBox.PasswordChar = '*';
            this.confirmPasswordTxtBox.Size = new System.Drawing.Size(451, 38);
            this.confirmPasswordTxtBox.TabIndex = 5;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(340, 412);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(300, 65);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.registerBtn.MouseEnter += new System.EventHandler(this.registrationBtnEnter);
            this.registerBtn.MouseLeave += new System.EventHandler(this.registrationBtnLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Password:";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(363, 213);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(451, 38);
            this.passwordTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 487);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Already Have An Account   -->";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginLbl.Location = new System.Drawing.Point(552, 487);
            this.loginLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(33, 13);
            this.loginLbl.TabIndex = 10;
            this.loginLbl.Text = "Login";
            this.loginLbl.Click += new System.EventHandler(this.loginlbl_click);
            this.loginLbl.MouseEnter += new System.EventHandler(this.LblEnter);
            this.loginLbl.MouseLeave += new System.EventHandler(this.LblLeave);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.confirmPasswordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registerForm_FormClosed);
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPasswordTxtBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loginLbl;
    }
}
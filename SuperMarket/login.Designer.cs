namespace SuperMarket
{
    partial class loginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password:";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(361, 187);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(451, 38);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(361, 276);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(451, 38);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(353, 408);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(300, 65);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtnEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtnLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 482);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dont Have An Account Register Here    -->";
            // 
            // RegisterLbl
            // 
            this.RegisterLbl.AutoSize = true;
            this.RegisterLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RegisterLbl.Location = new System.Drawing.Point(584, 482);
            this.RegisterLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterLbl.Name = "RegisterLbl";
            this.RegisterLbl.Size = new System.Drawing.Size(46, 13);
            this.RegisterLbl.TabIndex = 6;
            this.RegisterLbl.Text = "Register";
            this.RegisterLbl.Click += new System.EventHandler(this.registerLbl_Click);
            this.RegisterLbl.MouseEnter += new System.EventHandler(this.LblEnter);
            this.RegisterLbl.MouseLeave += new System.EventHandler(this.LblLeave);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.RegisterLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RegisterLbl;
    }
}


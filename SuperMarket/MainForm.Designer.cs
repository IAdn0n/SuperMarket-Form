namespace SuperMarket
{
    partial class MainForm
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
            this.BasketBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BasketBtn
            // 
            this.BasketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketBtn.Location = new System.Drawing.Point(585, 15);
            this.BasketBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BasketBtn.Name = "BasketBtn";
            this.BasketBtn.Size = new System.Drawing.Size(103, 46);
            this.BasketBtn.TabIndex = 0;
            this.BasketBtn.Text = "Basket (0)";
            this.BasketBtn.UseVisualStyleBackColor = true;
            this.BasketBtn.Click += new System.EventHandler(this.BasketBtn_Click);
            this.BasketBtn.MouseEnter += new System.EventHandler(this.BtnEnter);
            this.BasketBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.Location = new System.Drawing.Point(703, 15);
            this.ShopBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(103, 46);
            this.ShopBtn.TabIndex = 1;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.MouseEnter += new System.EventHandler(this.BtnEnter);
            this.ShopBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ProfileBtn.FlatAppearance.BorderSize = 10;
            this.ProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.Location = new System.Drawing.Point(821, 15);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(103, 46);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Cick);
            this.ProfileBtn.MouseEnter += new System.EventHandler(this.BtnEnter);
            this.ProfileBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------\r\n\r\n";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(36, 15);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(103, 46);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            this.LogoutBtn.MouseEnter += new System.EventHandler(this.BtnEnterRed);
            this.LogoutBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // productsPanel
            // 
            this.productsPanel.AutoScroll = true;
            this.productsPanel.Location = new System.Drawing.Point(36, 153);
            this.productsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(876, 426);
            this.productsPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.BasketBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BasketBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Panel productsPanel;
    }
}
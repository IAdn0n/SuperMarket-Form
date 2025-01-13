namespace SuperMarket
{
    partial class ProfileForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.basketBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiptsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(36, 15);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 46);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "<-------";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // basketBtn
            // 
            this.basketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketBtn.Location = new System.Drawing.Point(585, 15);
            this.basketBtn.Margin = new System.Windows.Forms.Padding(2);
            this.basketBtn.Name = "basketBtn";
            this.basketBtn.Size = new System.Drawing.Size(103, 46);
            this.basketBtn.TabIndex = 11;
            this.basketBtn.Text = "Basket (0)";
            this.basketBtn.UseVisualStyleBackColor = true;
            // 
            // ShopBtn
            // 
            this.ShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.Location = new System.Drawing.Point(703, 15);
            this.ShopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(103, 46);
            this.ShopBtn.TabIndex = 12;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ProfileBtn.FlatAppearance.BorderSize = 10;
            this.ProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.Location = new System.Drawing.Point(821, 15);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(103, 46);
            this.ProfileBtn.TabIndex = 13;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(33, 80);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(134, 46);
            this.usernameLbl.TabIndex = 14;
            this.usernameLbl.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------\r\n\r\n";
            // 
            // ReceiptsPanel
            // 
            this.ReceiptsPanel.AutoScroll = true;
            this.ReceiptsPanel.Location = new System.Drawing.Point(36, 153);
            this.ReceiptsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ReceiptsPanel.Name = "ReceiptsPanel";
            this.ReceiptsPanel.Size = new System.Drawing.Size(876, 426);
            this.ReceiptsPanel.TabIndex = 16;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.ReceiptsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.basketBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button basketBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ReceiptsPanel;
    }
}
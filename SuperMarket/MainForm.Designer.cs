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
            this.SuspendLayout();
            // 
            // BasketBtn
            // 
            this.BasketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketBtn.Location = new System.Drawing.Point(878, 23);
            this.BasketBtn.Name = "BasketBtn";
            this.BasketBtn.Size = new System.Drawing.Size(155, 71);
            this.BasketBtn.TabIndex = 0;
            this.BasketBtn.Text = "Basket";
            this.BasketBtn.UseVisualStyleBackColor = true;
            this.BasketBtn.MouseEnter += new System.EventHandler(this.BasketBtnEnter);
            this.BasketBtn.MouseLeave += new System.EventHandler(this.BasketBtnLeave);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.Location = new System.Drawing.Point(1055, 23);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(155, 71);
            this.ShopBtn.TabIndex = 1;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.MouseEnter += new System.EventHandler(this.shopBtnEnter);
            this.ShopBtn.MouseLeave += new System.EventHandler(this.shopBtnLeave);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ProfileBtn.FlatAppearance.BorderSize = 10;
            this.ProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.Location = new System.Drawing.Point(1231, 23);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(155, 71);
            this.ProfileBtn.TabIndex = 2;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.MouseEnter += new System.EventHandler(this.profileBtnEnter);
            this.ProfileBtn.MouseLeave += new System.EventHandler(this.profileBtnLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1410, 922);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.BasketBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BasketBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button ProfileBtn;
    }
}
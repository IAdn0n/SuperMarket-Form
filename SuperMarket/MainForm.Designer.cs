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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.BasketBtn.Click += new System.EventHandler(this.BasketBtn_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(539, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Milk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(103, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "0.99$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuperMarket.Properties.Resources.Milk;
            this.pictureBox1.Location = new System.Drawing.Point(18, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1410, 922);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.BasketBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BasketBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
namespace SuperMarket
{
    partial class addProduct
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
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.productPriceLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.decrementBtn = new System.Windows.Forms.Button();
            this.incrementbtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(24, 28);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 46);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "<---";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            this.backBtn.MouseEnter += new System.EventHandler(this.BtnEnterRed);
            this.backBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Location = new System.Drawing.Point(24, 111);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(302, 270);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 1;
            this.productPictureBox.TabStop = false;
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLbl.Location = new System.Drawing.Point(479, 132);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(91, 46);
            this.productNameLbl.TabIndex = 2;
            this.productNameLbl.Text = "Milk";
            // 
            // productPriceLbl
            // 
            this.productPriceLbl.AutoSize = true;
            this.productPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLbl.Location = new System.Drawing.Point(479, 196);
            this.productPriceLbl.Name = "productPriceLbl";
            this.productPriceLbl.Size = new System.Drawing.Size(130, 46);
            this.productPriceLbl.TabIndex = 3;
            this.productPriceLbl.Text = "0.99 $";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.White;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(427, 328);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(64, 46);
            this.quantityLbl.TabIndex = 4;
            this.quantityLbl.Text = "01";
            // 
            // decrementBtn
            // 
            this.decrementBtn.BackColor = System.Drawing.Color.White;
            this.decrementBtn.Enabled = false;
            this.decrementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrementBtn.Location = new System.Drawing.Point(381, 328);
            this.decrementBtn.Name = "decrementBtn";
            this.decrementBtn.Size = new System.Drawing.Size(40, 43);
            this.decrementBtn.TabIndex = 5;
            this.decrementBtn.Text = "-";
            this.decrementBtn.UseVisualStyleBackColor = false;
            this.decrementBtn.Click += new System.EventHandler(this.decrementBtn_Click);
            this.decrementBtn.MouseEnter += new System.EventHandler(this.BtnEnterRed);
            this.decrementBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // incrementbtn
            // 
            this.incrementbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementbtn.Location = new System.Drawing.Point(497, 328);
            this.incrementbtn.Name = "incrementbtn";
            this.incrementbtn.Size = new System.Drawing.Size(40, 43);
            this.incrementbtn.TabIndex = 6;
            this.incrementbtn.Text = "+";
            this.incrementbtn.UseVisualStyleBackColor = true;
            this.incrementbtn.Click += new System.EventHandler(this.incrementbtn_Click);
            this.incrementbtn.MouseEnter += new System.EventHandler(this.BtnEnterGreen);
            this.incrementbtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(164, 436);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(373, 53);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.addProductIntoBasket);
            this.confirmBtn.MouseEnter += new System.EventHandler(this.BtnEnterGreen);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // backBtn2
            // 
            this.backBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn2.Location = new System.Drawing.Point(164, 518);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(373, 53);
            this.backBtn2.TabIndex = 9;
            this.backBtn2.Text = "Back";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn_Click);
            this.backBtn2.MouseEnter += new System.EventHandler(this.BtnEnterRed);
            this.backBtn2.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total:";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(479, 260);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(130, 46);
            this.TotalLbl.TabIndex = 13;
            this.TotalLbl.Text = "0.99 $";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 637);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn2);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.incrementbtn);
            this.Controls.Add(this.decrementBtn);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.productPriceLbl);
            this.Controls.Add(this.productNameLbl);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.backBtn);
            this.Name = "addProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Product";
            this.Load += new System.EventHandler(this.addProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.Label productPriceLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button decrementBtn;
        private System.Windows.Forms.Button incrementbtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalLbl;
    }
}
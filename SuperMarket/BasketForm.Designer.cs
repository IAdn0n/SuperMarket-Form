namespace SuperMarket
{
    partial class BasketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BasketBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsCounterLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.productsGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(54, 23);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(155, 71);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "<-------";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------\r\n\r\n";
            // 
            // BasketBtn
            // 
            this.BasketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketBtn.Location = new System.Drawing.Point(878, 23);
            this.BasketBtn.Name = "BasketBtn";
            this.BasketBtn.Size = new System.Drawing.Size(155, 71);
            this.BasketBtn.TabIndex = 10;
            this.BasketBtn.Text = "Basket";
            this.BasketBtn.UseVisualStyleBackColor = true;
            // 
            // ShopBtn
            // 
            this.ShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.Location = new System.Drawing.Point(1055, 23);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(155, 71);
            this.ShopBtn.TabIndex = 11;
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
            this.ProfileBtn.Location = new System.Drawing.Point(1231, 23);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(155, 71);
            this.ProfileBtn.TabIndex = 12;
            this.ProfileBtn.Text = "Profile";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.vScrollBar1);
            this.productsGroupBox.Location = new System.Drawing.Point(54, 235);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(852, 675);
            this.productsGroupBox.TabIndex = 13;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "groupBox1";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(804, 13);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 650);
            this.vScrollBar1.TabIndex = 0;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.BackColor = System.Drawing.Color.White;
            this.SummaryGroupBox.Controls.Add(this.checkoutBtn);
            this.SummaryGroupBox.Controls.Add(this.totalLbl);
            this.SummaryGroupBox.Controls.Add(this.taxLbl);
            this.SummaryGroupBox.Controls.Add(this.subtotalLbl);
            this.SummaryGroupBox.Controls.Add(this.label5);
            this.SummaryGroupBox.Controls.Add(this.label4);
            this.SummaryGroupBox.Controls.Add(this.label3);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(958, 235);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(353, 332);
            this.SummaryGroupBox.TabIndex = 14;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Order Summary";
            // 
            // itemsCounterLbl
            // 
            this.itemsCounterLbl.AutoSize = true;
            this.itemsCounterLbl.Location = new System.Drawing.Point(258, 163);
            this.itemsCounterLbl.Name = "itemsCounterLbl";
            this.itemsCounterLbl.Size = new System.Drawing.Size(62, 20);
            this.itemsCounterLbl.TabIndex = 15;
            this.itemsCounterLbl.Text = "0 Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total:";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLbl.Location = new System.Drawing.Point(236, 95);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(34, 25);
            this.subtotalLbl.TabIndex = 3;
            this.subtotalLbl.Text = "10";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(236, 147);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(34, 25);
            this.taxLbl.TabIndex = 4;
            this.taxLbl.Text = "10";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(236, 202);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(34, 25);
            this.totalLbl.TabIndex = 5;
            this.totalLbl.Text = "10";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(35, 260);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(260, 42);
            this.checkoutBtn.TabIndex = 6;
            this.checkoutBtn.Text = "Continue Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1410, 922);
            this.Controls.Add(this.itemsCounterLbl);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.productsGroupBox);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.BasketBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.productsGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BasketBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label itemsCounterLbl;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
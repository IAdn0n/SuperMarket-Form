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
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemsCounterLbl = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(36, 15);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 46);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "<-------";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.shopBtn_Clicked);
            this.backBtn.MouseEnter += new System.EventHandler(this.BtnEnterRed);
            this.backBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------------\r\n\r\n";
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
            this.SummaryGroupBox.Location = new System.Drawing.Point(639, 153);
            this.SummaryGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SummaryGroupBox.Size = new System.Drawing.Size(235, 216);
            this.SummaryGroupBox.TabIndex = 14;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Order Summary";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.Location = new System.Drawing.Point(23, 169);
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(173, 27);
            this.checkoutBtn.TabIndex = 6;
            this.checkoutBtn.Text = "Continue Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtnCick);
            this.checkoutBtn.MouseEnter += new System.EventHandler(this.BtnEnter);
            this.checkoutBtn.MouseLeave += new System.EventHandler(this.BtnLeave);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(157, 131);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(24, 17);
            this.totalLbl.TabIndex = 5;
            this.totalLbl.Text = "10";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLbl.Location = new System.Drawing.Point(157, 96);
            this.taxLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(24, 17);
            this.taxLbl.TabIndex = 4;
            this.taxLbl.Text = "10";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLbl.Location = new System.Drawing.Point(157, 62);
            this.subtotalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(24, 17);
            this.subtotalLbl.TabIndex = 3;
            this.subtotalLbl.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal:";
            // 
            // itemsCounterLbl
            // 
            this.itemsCounterLbl.AutoSize = true;
            this.itemsCounterLbl.Location = new System.Drawing.Point(172, 106);
            this.itemsCounterLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemsCounterLbl.Name = "itemsCounterLbl";
            this.itemsCounterLbl.Size = new System.Drawing.Size(41, 13);
            this.itemsCounterLbl.TabIndex = 15;
            this.itemsCounterLbl.Text = "0 Items";
            // 
            // productsPanel
            // 
            this.productsPanel.AutoScroll = true;
            this.productsPanel.Location = new System.Drawing.Point(36, 153);
            this.productsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(571, 430);
            this.productsPanel.TabIndex = 16;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.itemsCounterLbl);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BasketForm_FormClosed);
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label itemsCounterLbl;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel productsPanel;
    }
}
namespace SuperMarket
{
    partial class ReceiptInfo
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.Red;
            this.NameLbl.Location = new System.Drawing.Point(93, 19);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(61, 24);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.Red;
            this.DateLbl.Location = new System.Drawing.Point(93, 43);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(110, 24);
            this.DateLbl.TabIndex = 3;
            this.DateLbl.Text = "dd/mm/yyyy";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Location = new System.Drawing.Point(22, 67);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(283, 13);
            this.lineLabel.TabIndex = 4;
            this.lineLabel.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // ReceiptInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label1);
            this.Name = "ReceiptInfo";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.ReceiptInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label lineLabel;
    }
}
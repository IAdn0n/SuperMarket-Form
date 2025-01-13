using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class ReceiptInfo : Form
    {
        private string id;
        private int x = 25;
        private int y = 94;
        private const int width = 253;
        private const int height = 109;
        private const int padding = 10;

        private int nameX = 6;
        private int nameY = 40;

        private int quantityX = 167;
        private int quantityY = 16;

        private int priceX = 167;
        private int priceY = 40;

        private int totalX = 167;
        private int totalY = 82;

        private double TotalPrice = 0;

        private Font fnt;
        public ReceiptInfo(string ReceiptID)
        {
            InitializeComponent();
            id = ReceiptID;
            fnt = new Font("", 14);
        }

        private void ReceiptInfo_Load(object sender, EventArgs e)
        {
            string[] receipt = File.ReadLines(Constants.FileMethods.RECEIPT_FILE).Skip(int.Parse(id) - 1).Take(1).First().Split(',');
            DateLbl.Text = receipt[2];
            NameLbl.Text = User.getName(receipt[1]);
             

            //add every items from receipt
            renderProducts();

            //add a line
            Label line = new Label();
            line.Text = lineLabel.Text;
            line.Location = new Point(22, y);
            line.AutoSize = true;
            y += (padding + 20);
            this.Controls.Add(line);

            //label that says "Total PRice: "
            Label PRICE = new Label();
            PRICE.Text = "Total Price: ";
            PRICE.Font = fnt;
            PRICE.AutoSize = true;
            PRICE.Location = new Point(x + nameX, y);
            this.Controls.Add(PRICE);

            //add total price
            Label total = new Label();
            total.Text = TotalPrice.ToString();
            total.Font = fnt;
            total.ForeColor = Color.ForestGreen;
            total.Location = new Point(x+ totalX, y);
            this.Controls.Add(total);


            Label Ignore = new Label();
            Ignore.Text = String.Empty;
            Ignore.Location = new Point(0, y+80);
            this.Controls.Add(Ignore);
        }

        private void renderProducts()
        {
            StreamReader file = File.OpenText(Constants.FileMethods.RECEIPT_PRODUCT_FILE);

            while(!file.EndOfStream)
            {
                string[] info = file.ReadLine().Split(',');
                if (info[1] == id)
                {
                    createGroupBox(info[0], info[2], x, y);
                    y += (height + padding);
                }
            }
            file.Close();
        }

        private void createGroupBox(string id, string quantity, int x, int y)
        {
            string[] product = File.ReadLines(Constants.FileMethods.PRODUCT_FILE).Skip(int.Parse(id)-1).Take(1).First().Split(',');
            GroupBox gb = new GroupBox();
            gb.Location = new Point(x, y);
            gb.Size = new Size(width, height);
            gb.Text = String.Empty;

            Label name = new Label();
            name.Text = product[1];
            name.Font = fnt;
            name.Location = new Point(nameX, nameY);
            gb.Controls.Add(name);

            Label q  = new Label();
            q.Text = 'x' + quantity;
            q.Font = fnt;
            q.Location = new Point(quantityX, quantityY);
            gb.Controls.Add(q);

            Label price = new Label();
            price.Text = '$' + product[2];
            price.Font = fnt;
            price.ForeColor = Color.ForestGreen;
            price.Location = new Point(priceX, priceY);
            gb.Controls.Add(price);


            Label total  = new Label();
            total.Text = '$' + (double.Parse(product[2]) * double.Parse(quantity)).ToString();
            total.Font = fnt;
            total.ForeColor = Color.ForestGreen;
            total.Location = new Point(totalX, totalY);
            gb.Controls.Add(total);

            this.TotalPrice += (double.Parse(product[2]) * double.Parse(quantity));

            this.Controls.Add(gb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{        
    public class Product
    {
        private string ID;
        private string name;
        private double price;
        private int quantity;
        private string imagePath;

        public Product(string ID, string name, double price, int quantity, string imagePath)
        {   
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.imagePath = imagePath;
        }

        public static GroupBox addProduct(Product p, int x, int y)
        {
            //creating group Box
            GroupBox gp = new GroupBox();
            gp.Width = Constants.ProductSizes.WIDTH;
            gp.Height = Constants.ProductSizes.HEIGHT;
            gp.BackColor = Color.White;
            gp.Text = p.name;
            gp.Name = p.ID;
            gp.Font = new Font("", Constants.ProductSizes.FONT_SIZE, FontStyle.Bold);

            //creating price label
            Label price = new Label();
            price.Text = p.price.ToString() + "$";
            price.Location = new Point(Constants.ProductSizes.PRICE_X, Constants.ProductSizes.PRICE_Y);
            price.ForeColor = Color.ForestGreen;
            price.Font = new Font("", Constants.ProductSizes.FONT_SIZE, FontStyle.Bold);

            gp.Controls.Add(price);


            //creating image
            PictureBox picture = new PictureBox();
            picture.ImageLocation = p.imagePath;
            picture.Width = Constants.ProductSizes.IMAGE_WIDTH;
            picture.Height = Constants.ProductSizes.IMAGE_HEIGHT;
            picture.Location = new Point(Constants.ProductSizes.IMAGE_X, Constants.ProductSizes.IMAGE_Y);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            gp.Controls.Add(picture);


            gp.Location = new Point(x, y);
            return gp;
        }

        public string getID() { return ID; }
        public string getName() { return name; }
        public double getPrice() { return price; }
        public string getImagePath() { return imagePath;}
        public int getQuantity() { return quantity; }
    }
}

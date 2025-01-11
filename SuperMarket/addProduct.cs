using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class addProduct : Form
    {
        Product product;
        Basket basket;
        int quantity;
        public addProduct(Product product, Basket basket)
        {
            InitializeComponent();
            this.product = product;
            this.basket = basket;
            this.quantity = 1;
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            productNameLbl.Text = product.getName();
            productPriceLbl.Text = '$' + product.getPrice().ToString();
            TotalLbl.Text = productPriceLbl.Text;
            productPictureBox.ImageLocation = product.getImagePath();
        }


        //incrementing the quantity
        private void incrementbtn_Click(object sender, EventArgs e)
        {
            quantity++;
            quantityLbl.Text = (quantity < 10) ? "0" + quantity.ToString() : quantity.ToString();

            TotalLbl.Text = '$' + (product.getPrice() * quantity).ToString();

            if (quantity == product.getQuantity() || quantity == 99)
                incrementbtn.Enabled = false;
            if (quantity > 1)
                decrementBtn.Enabled = true;
            
        }

        //decrementing the quantity
        private void decrementBtn_Click(object sender, EventArgs e)
        {
            quantity--;
            quantityLbl.Text = (quantity < 10) ? "0" + quantity.ToString() : quantity.ToString();

            TotalLbl.Text = '$' + (product.getPrice() * quantity).ToString();

            if (quantity == 1)
                decrementBtn.Enabled = false;
            if (quantity < product.getQuantity() && quantity < 99) 
                incrementbtn.Enabled = true;
        }

        //confirming --> addding products into basket
        private void addProductIntoBasket(object sender, EventArgs e)
        {
            Product added = product;
            added.setQuantity(this.quantity);
            basket.add(added);

            Console.WriteLine("Product added into basket");
            this.Close();
        }


        //buttons hovers

        private void BtnEnterGreen(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Constants.ControlMethods.BTN_ENTER(btn);

        }
        private void BtnEnterRed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Constants.ControlMethods.BTN_ENTER_COLOR(btn, Color.LightCoral);

        }
        private void BtnLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Constants.ControlMethods.BTN_LEAVE(btn);
        }


        //leaving site
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WindowSizes.WIDTH, Constants.WindowSizes.HEIGHT);

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddProducts();
        }

        private void BasketBtn_Click(object sender, EventArgs e)
        {
        }


        //adding a product;
        private void AddProducts()
        {

            //FOR TESTING PURPOSES
            Product [] pds = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                pds[i] = new Product(i.ToString(), "Milk", 0.99);
            }

            // END TESTING


            //adding products;
            for (int i = 1; i <= 10; i++)
            {
                int xi = ((i % 5 == 0) ? 5 : i % 5);
                int x = Constants.ProductSizes.START_X * xi + Constants.ProductSizes.WIDTH * (xi - 1);
                
                int yi = (int)(Math.Ceiling((decimal)i / 5));
                int y = Constants.ProductSizes.START_Y;
                y += Constants.ProductSizes.PADDING_Y * (yi-1) + Constants.ProductSizes.HEIGHT * (yi - 1);

                GroupBox gb = Product.addProduct(pds[i-1], x, y);
                this.Controls.Add(gb);
                
                Console.WriteLine(x + " " + y);
            }
            
            Console.WriteLine("Products loaded successfully");
        }  
        




        //for shop btn changing colors
        private void shopBtnEnter(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_ENTER(ShopBtn);
        }
        private void shopBtnLeave(Object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_LEAVE(ShopBtn);
        }
        //for profile btn changing color
        private void profileBtnEnter(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_ENTER(ProfileBtn);
        }
        private void profileBtnLeave(Object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_LEAVE(ProfileBtn);
        }
        //for basket btn changing color
        private void BasketBtnEnter(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_ENTER(BasketBtn);
        }
        private void BasketBtnLeave(object sender, EventArgs e)
        {
            Constants.ControlMethods.BTN_LEAVE(BasketBtn);
        }

        
    }
}

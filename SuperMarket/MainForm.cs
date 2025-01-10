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
        private Form previousForm;
        public MainForm(Form prev)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WindowSizes.WIDTH, Constants.WindowSizes.HEIGHT);

            this.previousForm = prev;
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
            Product [] pds = new Product[20];

            for (int i = 0; i < 20; i++)
            {
                pds[i] = new Product(i.ToString(), "Milk", 0.99);
            }

            // END TESTING


            //adding products;
            int lastY = 0;
            for (int i = 1; i <= 20; i++)
            {
                int xi = ((i % 5 == 0) ? 5 : i % 5);
                int x = Constants.ProductSizes.START_X * xi + Constants.ProductSizes.WIDTH * (xi - 1);
                
                int yi = (int)(Math.Ceiling((decimal)i / 5));
                int y = Constants.ProductSizes.START_Y;
                y += Constants.ProductSizes.PADDING_Y * (yi-1) + Constants.ProductSizes.HEIGHT * (yi - 1);

                GroupBox gb = Product.addProduct(pds[i-1], x, y);

                gb.MouseEnter += productMouseEnter;
                gb.MouseLeave += productMouseLeave;
                foreach (Control c in gb.Controls)
                {
                    c.MouseEnter += parentProductMouseEnter;
                    c.MouseLeave += parentProductMouseLeave;
                }
                
                this.Controls.Add(gb);
                
                Console.WriteLine(x + " " + y);

                lastY = y;
            }
            
            //for extra padding
            Panel ignore = new Panel();
            ignore.Location = new Point(0, lastY + Constants.ProductSizes.HEIGHT);
            this.Controls.Add(ignore);
            

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

        //for product hovering
        //for mouse Entering
        private void productMouseEnter(object sender, EventArgs e)
        {   
            Control control = sender as Control;
            control.BackColor = Color.ForestGreen;
            control.ForeColor = Color.White;
            foreach (Control c in control.Controls)
                c.ForeColor = Color.White;
        }
        private void parentProductMouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.Parent.BackColor = Color.ForestGreen;
            control.Parent.ForeColor = Color.White;
            foreach (Control c in control.Parent.Controls)
                c.ForeColor = Color.White;
        }
        //for mouse leaving
        private void productMouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.White;
            control.ForeColor = Color.Black;
            foreach (Control c in control.Controls)
                c.ForeColor = Color.ForestGreen;
        }
        private void parentProductMouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.Parent.BackColor = Color.White;
            control.Parent.ForeColor= Color.Black;
            foreach (Control c in control.Parent.Controls)
                c.ForeColor = Color.ForestGreen;
        }


        // close everything
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            previousForm.Close();
        }


        //testing purposes

        private void TEST(object sender, EventArgs e)
        {
            Console.WriteLine("TEST");
        }

        //end testing
    }
}

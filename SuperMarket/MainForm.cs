using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace SuperMarket
{
    public partial class MainForm : Form
    {
        private Form previousForm;
        private Basket basket;
        private User user;

        private const string filePath = Constants.FileMethods.PRODUCT_FILE;

        //TEMPORARY***********
        private Product[] pds = new Product[20];
        //

        private bool backToLogin = false;
        public MainForm(Form prev, User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WindowSizes.WIDTH, Constants.WindowSizes.HEIGHT);

            this.previousForm = prev;
            this.user = user;

            basket = new Basket();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            refreshForm();
            AddProductsIntoForm();

        }

        public void refreshForm()
        {
            //updating the number on basket btn
            Constants.BasketMethods.CHANGE_TEXT(BasketBtn, basket.Size());
        }

        private void BasketBtn_Click(object sender, EventArgs e)
        {

            BasketForm basketForm = new BasketForm(this, basket, user);
            this.Hide();
            
            basketForm.Activate();
            basketForm.Show();
        }

        private void ProfileBtn_Cick(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this, user);
            this.Hide();

            profileForm.Activate();
            profileForm.Show();

        }


        //adding a product;
        private void AddProductsIntoForm()
        {
            //tring to open file
            StreamReader file;
            try
            {
                file = File.OpenText(filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.Close();
                return;
            }

            int size = Constants.FileMethods.GetFileSize(filePath);
            //adding products;
            int lastY = 0;
            for (int i = 1; i <= size; i++)
            {
                string[] words = file.ReadLine().Split(',');

                int xi = ((i % 5 == 0) ? 5 : i % 5);
                int x = Constants.ProductSizes.START_X;
                x += Constants.ProductSizes.PADDING_X * (xi - 1) + Constants.ProductSizes.WIDTH * (xi - 1);

                int yi = (int)(Math.Ceiling((decimal)i / 5));
                int y = Constants.ProductSizes.START_Y;
                y += Constants.ProductSizes.PADDING_Y * (yi - 1) + Constants.ProductSizes.HEIGHT * (yi - 1);

                Product p = new Product(words[0], words[1], double.Parse(words[2]), int.Parse(words[3]), words[4]);
                GroupBox gb = Product.addProduct(p, x, y);

                gb.MouseEnter += productMouseEnter;
                gb.MouseLeave += productMouseLeave;

                gb.Click += productClicked;
                foreach (Control c in gb.Controls)
                {
                    c.MouseEnter += parentProductMouseEnter;
                    c.MouseLeave += parentProductMouseLeave;
                    c.Click += parentProductClicked;
                }

                //if products quantity get to 0
                if (p.getQuantity() == 0)
                {
                    gb.Enabled = false;
                    Label outOfStock = new Label();
                    outOfStock.Text = "Out Of Stock";
                    outOfStock.ForeColor = Color.Red;
                    outOfStock.BackColor = Color.Transparent;
                    outOfStock.Font = new Font("", 10);
                    outOfStock.Location = new Point(x + 20, y + 20);
                    this.productsPanel.Controls.Add(outOfStock);
                }

                this.productsPanel.Controls.Add(gb);
                
                Console.WriteLine(x + " " + y);

                lastY = y;
            }

            //close the file
            file.Close();


            //for extra padding
            Panel ignore = new Panel();
            ignore.Location = new Point(0, lastY + Constants.ProductSizes.HEIGHT);
            this.productsPanel.Controls.Add(ignore);
            

            Console.WriteLine("Products loaded successfully");
        }


        //clicked product
        private void productClicked(object sender, EventArgs e)
        {
            Control c = sender as Control;
            //fetching product's information
            int id = int.Parse(c.Name);
            string[] words = File.ReadLines(filePath).Skip(id-1).Take(1).First().Split(',');
            addProduct productForm = new addProduct(new Product(words[0], words[1], double.Parse(words[2]), int.Parse(words[3]), words[4]),  basket);

            //redraw the form after dialog completion
            if (productForm.ShowDialog() == DialogResult.Cancel)
                refreshForm();
        }
        private void parentProductClicked(object sender, EventArgs e)
        {
            productClicked((sender as Control).Parent, e);
        }



        //for btn changing colors when hovering
        private void BtnEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Constants.ControlMethods.BTN_ENTER(btn);
        }
        private void BtnLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Constants.ControlMethods.BTN_LEAVE(btn);
        }
        private void BtnEnterRed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Constants.ControlMethods.BTN_ENTER_COLOR(btn, Color.LightCoral);
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
            productMouseEnter((sender as Control).Parent, e);
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
            productMouseLeave((sender as Control).Parent, e);
        }


        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            previousForm.Activate();
            previousForm.Show();
            backToLogin = true;
            this.Close();
        }


        // close everything
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!backToLogin) previousForm.Close();
        }

    }
}

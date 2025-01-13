using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SuperMarket
{
    public partial class BasketForm : Form
    {
        private Basket basket;
        private Form previousForm;
        private User user;

        private bool backToMain = false;
        public BasketForm(Form prev, Basket basket, User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WindowSizes.WIDTH, Constants.WindowSizes.HEIGHT);

            this.previousForm = prev;
            this.user = user;

            this.basket = basket;
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void refreshForm()
        {
            //changing the label (0 items)
            itemsCounterLbl.Text = basket.Size().ToString() + " Items";

            //total prices changing
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 2;

            double tax = (basket.getTotalPrice() / 10.0);
            subtotalLbl.Text = '$' + basket.getTotalPrice().ToString("N", setPrecision);
            taxLbl.Text = '$' + tax.ToString("N", setPrecision);
            totalLbl.Text = '$' + (basket.getTotalPrice() + tax).ToString("N", setPrecision);

            //adding products
            productsPanel.Controls.Clear();
            int x = Constants.BasketMethods.PRODUCT_X, y = Constants.BasketMethods.PRODUCT_Y;
            int i = 0, lastY = y;
            foreach (Product p in basket.getProducts())
            {
                addProductGroupBox(p, i++, x, y);

                y += Constants.BasketMethods.PRODUCT_HEIGHT + Constants.BasketMethods.PRODUCT_Y;
                lastY = y;
            }
        }

        private void addProductGroupBox(Product p, int index, int x, int y)
        {
            GroupBox gb = new GroupBox();
            gb.Size = new Size(Constants.BasketMethods.PRODUCT_WIDTH, Constants.BasketMethods.PRODUCT_HEIGHT);
            gb.Name = index.ToString();
            gb.Text = String.Empty;
            gb.BackColor = Color.White;

            //adding picture into a group box
            PictureBox pic = new PictureBox();
            pic.Location = new Point(Constants.BasketMethods.PRODUCT_PICTURE_X, Constants.BasketMethods.PRODUCT_PICTURE_Y);
            pic.Size = new Size(Constants.BasketMethods.PRODUCT_PICTURE_WIDTH, Constants.BasketMethods.PRODUCT_PICTURE_HEIGHT);
            pic.ImageLocation = p.getImagePath();
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            gb.Controls.Add(pic);


            Font usedFnt = new Font("", Constants.BasketMethods.PRODUCT_FONT_SIZE);
            //adding name label into a group box
            Label name = new Label();
            name.Location = new Point(Constants.BasketMethods.PRODUCT_NAME_X, Constants.BasketMethods.PRODUCT_NAME_Y);
            name.Text = p.getName();
            name.Font = usedFnt;
            gb.Controls.Add(name);

            //adding price label
            Label price = new Label();
            price.Location = new Point(Constants.BasketMethods.PRODUCT_PRICE_X, Constants.BasketMethods.PRODUCT_PRICE_Y);
            price.Text = '$' + p.getPrice().ToString();
            price.Font = usedFnt;
            price.ForeColor = Color.ForestGreen;
            gb.Controls.Add(price);

            //adding quantity label
            Label quantity = new Label();
            quantity.Location = new Point(Constants.BasketMethods.PRODUCT_QUANTITY_X, Constants.BasketMethods.PRODUCT_QUANTITY_Y);
            quantity.Text = 'x' + p.getQuantity().ToString();
            quantity.Font = usedFnt;
            gb.Controls.Add(quantity);

            //adding totalprice label
            Label totalPrice = new Label();
            totalPrice.Location = new Point(Constants.BasketMethods.PRODUCT_TOTAL_PRICE_X, Constants.BasketMethods.PRODUCT_TOTAL_PRICE_Y);
            totalPrice.Text = '$' + (p.getPrice() * p.getQuantity()).ToString();
            totalPrice.Font = usedFnt;
            gb.Controls.Add(totalPrice);

            //adding X btn;
            Button cancel = new Button();
            cancel.Location = new Point(Constants.BasketMethods.PRODUCT_CANCEL_BTN_X, Constants.BasketMethods.PRODUCT_CANCEL_BTN_Y);
            cancel.Size = new Size(Constants.BasketMethods.PRODUCT_CANCEL_BTN_WIDTH, Constants.BasketMethods.PRODUCT_CANCEL_BTN_HEIGHT);
            cancel.Text = "X";
            cancel.MouseEnter += BtnEnterRed;
            cancel.MouseLeave += BtnLeave;
            cancel.Click += productCancelClick;
            gb.Controls.Add(cancel);


            gb.Location = new Point(x, y);

            this.productsPanel.Controls.Add(gb);
        }

        //checkout btn
        private void checkoutBtnCick(object sender, EventArgs e)
        {
            if (basket.getProducts().Count == 0)
            {
                MessageBox.Show("Empty Basket");
                return;
            }

            if (!ValidateAllProducts())
            {
                MessageBox.Show("Invalid amount of quantity");
                return;
            }

            //next receipt id to write (sequantial id)
            string nextReceiptId = (Constants.FileMethods.GetFileSize(Constants.FileMethods.RECEIPT_FILE) + 1).ToString();

            //writing a new receipt into receipt file;
            InsertReceipt(nextReceiptId);

            // m -> m relationship table
            InsertEachProduct(nextReceiptId);

            basket.clear();
            refreshForm();
            MessageBox.Show("Order Successful");
            Console.WriteLine("Order successful");
        }

        private bool ValidateAllProducts()
        {
            string[] lines = File.ReadAllLines(Constants.FileMethods.PRODUCT_FILE);
            foreach (Product p in basket.getProducts())
            {
                int id = int.Parse(p.getID());

                string[] info = lines[id-1].Split(',');
                if (info[0] == p.getID())
                {
                    int quantity = int.Parse(info[3]);
                    //if we buying more quantity than we have
                    if (p.getQuantity() > quantity) return false;


                    quantity -= p.getQuantity();
                    info[3] = quantity.ToString();
                    lines[id-1] = info[0] + ',' + info[1] + ',' + info[2] + ',' + info[3] + ',' + info[4];
                }
                
            }
            //update all products quantity
            File.WriteAllLines(Constants.FileMethods.PRODUCT_FILE, lines);
            //all test passed
            return true;
        }

        //insert new receipt into receipt file
        private void InsertReceipt(string id)
        {
            StreamWriter file = File.AppendText(Constants.FileMethods.RECEIPT_FILE);
            file.WriteLine(id + ',' + user.getID() + ',' + DateTime.Now.ToString("M/d/yyyy") + ',' + basket.getTotalPrice().ToString());
            file.Close();
        }

        //insert which receipt has which product
        private void InsertEachProduct(string id)
        {
            StreamWriter file = File.AppendText(Constants.FileMethods.RECEIPT_PRODUCT_FILE);
            foreach (Product p in basket.getProducts())
                file.WriteLine(p.getID() + ',' + id + ',' + p.getQuantity());
            file.Close(); 
        }



        //whenever the X(remove) btn in product groupbox in clicked
        private void productCancelClick(object sender, EventArgs e)
        {
            Control c = (sender as Control).Parent;
            basket.remove(int.Parse(c.Name));
            refreshForm();
        }


        private void shopBtn_Clicked(object sender, EventArgs e)
        {
            previousForm.Activate();
            previousForm.Show();

            backToMain = true;
            this.Close();
        }


        //method for btns changing colors when hovering
        private void BtnEnter(object sender, EventArgs e)
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

        // close everything
        private void BasketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm m = (MainForm)previousForm;
            m.refreshForm();
            if (!backToMain) previousForm.Close();
        }
    }
}

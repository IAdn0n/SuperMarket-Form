using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class ProfileForm : Form
    {
        private Form previousForm;
        private User user;

        private bool backToMain = false;
        public ProfileForm(Form previousForm, User user)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.user = user;

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = user.getName();

            RenderReceipts();
        }

        private void RenderReceipts()
        {
            StreamReader file;
            try
            {
                file = File.OpenText(Constants.FileMethods.RECEIPT_FILE);
            }catch(Exception ex) { MessageBox.Show(ex.Message); return; }


            int x = Constants.ReceiptSizes.RECEIPT_START_X, y = Constants.ReceiptSizes.RECEIPT_START_Y;
            //read all receipts
            while(!file.EndOfStream) {
                string[] words = file.ReadLine().Split(',');
                if (words[1] == user.getID())
                {
                    CreateReceiptGb(words[0], User.getName(words[1]), words[2], words[3], x, y);
                    y += Constants.ReceiptSizes.RECEIPT_HEIGHT + Constants.ReceiptSizes.RECEIPT_Y_PADDING;

                    Console.WriteLine("Receipt rendered successfully");
                }

            }
            file.Close();
        }

        private void CreateReceiptGb(string id, string name, string date, string total, int x, int y)
        {
            GroupBox gb = new GroupBox();
            gb.Name = id;
            gb.Size = new Size(Constants.ReceiptSizes.RECEIPT_WIDTH, Constants.ReceiptSizes.RECEIPT_HEIGHT);
            gb.Location = new Point(x, y);
            gb.BackColor = Color.White;
            gb.Text = String.Empty;

            Font fnt = new Font("", Constants.ReceiptSizes.RECEIPT_FONT_SIZE);

            //creating ID lbl
            Label IDLbl = new Label();
            IDLbl.Text = id;
            IDLbl.Font = fnt;
            IDLbl.Location = new Point(Constants.ReceiptSizes.ID_LBL_X, Constants.ReceiptSizes.ID_LBL_Y);
            IDLbl.MouseEnter += ParentMouseEnter;
            IDLbl.MouseLeave += ParentMouseLeave;
            IDLbl.Click += ParentMouseCick;
            gb.Controls.Add(IDLbl);

            //creating name LBL
            Label NameLbl = new Label();
            NameLbl.Text = name;
            NameLbl.Font = fnt;
            NameLbl.Location = new Point(Constants.ReceiptSizes.NAME_LBL_X, Constants.ReceiptSizes.NAME_LBL_Y);
            NameLbl.MouseEnter += ParentMouseEnter;
            NameLbl.MouseLeave += ParentMouseLeave;
            NameLbl.Click += ParentMouseCick;
            gb.Controls.Add(NameLbl);

            //creating date lbl
            Label DateLbl = new Label();
            DateLbl.Text = date;
            DateLbl.Font = fnt;
            DateLbl.Location = new Point(Constants.ReceiptSizes.DATE_LBL_X, Constants.ReceiptSizes.DATE_LBL_Y);
            DateLbl.MouseEnter += ParentMouseEnter;
            DateLbl.MouseLeave += ParentMouseLeave;
            DateLbl.Click += ParentMouseCick;
            gb.Controls.Add(DateLbl);

            //creating total price lbl
            Label PriceLbl = new Label();
            PriceLbl.Text = '$' + total;
            PriceLbl.Font = fnt;
            PriceLbl.ForeColor = Color.ForestGreen;
            PriceLbl.Location = new Point(Constants.ReceiptSizes.PRICE_LBL_X, Constants.ReceiptSizes.PRICE_LBL_Y);
            PriceLbl.MouseEnter += ParentMouseEnter;
            PriceLbl.MouseLeave += ParentMouseLeave;
            PriceLbl.Click += ParentMouseCick;
            gb.Controls.Add(PriceLbl);

            gb.MouseEnter += ReceiptMouseEnter;
            gb.MouseLeave += ReceiptMouseLeave;
            gb.Click += ReceiptMouseClick;
            this.ReceiptsPanel.Controls.Add(gb);
        }

        //whenever receipt is clicked
        private void ReceiptMouseClick(object sender, EventArgs e)
        {
            ReceiptInfo form = new ReceiptInfo((sender as Control).Name);
            form.Show();
        }
        private void ParentMouseCick(object sender, EventArgs e)
        {
            ReceiptMouseClick((sender as Control).Parent, e);
        }


        //for receipt hovering
        //for mouse Entering
        private void ReceiptMouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.ForestGreen;
            control.ForeColor = Color.White;
            foreach (Control c in control.Controls)
                c.ForeColor = Color.White;
        }
        private void ParentMouseEnter(object sender, EventArgs e)
        {
            ReceiptMouseEnter((sender as Control).Parent, e);
        }
        //for mouse leaving
        private void ReceiptMouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.White;
            control.ForeColor = Color.Black;
            foreach (Control c in control.Controls)
                c.ForeColor = Color.Black;
            control.Controls[Controls.Count - 2].ForeColor = Color.ForestGreen;
        }
        private void ParentMouseLeave(object sender, EventArgs e)
        {
            ReceiptMouseLeave((sender as Control).Parent, e);
        }



        //methods for btn hovering
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


        //closing functions
        private void backBtn_Click(object sender, EventArgs e)
        {
            previousForm.Activate();
            previousForm.Show();
            backToMain = true;
            this.Close();
        }


        // close everything
        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!backToMain) previousForm.Close();
        }
    }
}

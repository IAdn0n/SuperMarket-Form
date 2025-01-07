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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Size = new Size(Constants.WIDTH, Constants.HEIGHT);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        //for changing colors of btns
        private void BtnEnter(Button hoverBtn)
        {
            hoverBtn.BackColor = Color.ForestGreen;
            hoverBtn.ForeColor = Color.White;
        }
        private void BtnLeave(Button hoverBtn)
        {
            hoverBtn.BackColor = Color.Transparent;
            hoverBtn.ForeColor = Color.Black;
        }


        //for shop btn changing colors
        private void shopBtnEnter(object sender, EventArgs e)
        {
            BtnEnter(ShopBtn);
        }
        private void shopBtnLeave(Object sender, EventArgs e)
        {
            BtnLeave(ShopBtn);
        }
        //for profile btn changing color
        private void profileBtnEnter(object sender, EventArgs e)
        {
            BtnEnter(ProfileBtn);
        }
        private void profileBtnLeave(Object sender, EventArgs e)
        {
            BtnLeave(ProfileBtn);
        }
        //for basket btn changing color
        private void BasketBtnEnter(object sender, EventArgs e)
        {
            BtnEnter(BasketBtn);
        }
        private void BasketBtnLeave(object sender, EventArgs e)
        {
            BtnLeave(BasketBtn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public static class Constants
    {
        internal static class WindowSizes { 
            public static int WIDTH = 960;
            public static int HEIGHT = 640;
        }

        internal static class ProductSizes
        {
            public static int WIDTH = 133;
            public static int HEIGHT = 131;
            public static int PADDING_X = 30;
            public static int PADDING_Y = 50;
            public static int START_X = 20;
            public static int START_Y = 16;
            public static int FONT_SIZE = 14;

            public static int IMAGE_WIDTH = 120;
            public static int IMAGE_HEIGHT = 90;
            public static int IMAGE_X = 6;
            public static int IMAGE_Y = 31;


            public static int PRICE_X = 65;
            public static int PRICE_Y = 0;
            
        }

        internal static class ControlMethods
        {
            public static void BTN_ENTER(Button hoverBtn)
            {
                hoverBtn.BackColor = Color.ForestGreen;
                hoverBtn.ForeColor = Color.White;
            }
            public static void BTN_LEAVE(Button hoverBtn)
            {
                hoverBtn.BackColor = Color.Transparent;
                hoverBtn.ForeColor = Color.Black;
            }

            public static void BTN_ENTER_COLOR(Button hoverBtn, Color c)
            {
                hoverBtn.BackColor = c;
                hoverBtn.ForeColor = Color.Black;
            }
        }

        internal static class BasketMethods
        {
            public static int PRODUCT_X = 8;
            public static int PRODUCT_Y = 18;
            public static int PRODUCT_WIDTH = 510;
            public static int PRODUCT_HEIGHT = 95;
            public static int PRODUCT_FONT_SIZE = 12;

            public static int PRODUCT_PICTURE_X = 10;
            public static int PRODUCT_PICTURE_Y = 16;
            public static int PRODUCT_PICTURE_WIDTH = 72;
            public static int PRODUCT_PICTURE_HEIGHT = 68;

            public static int PRODUCT_NAME_X = 86;
            public static int PRODUCT_NAME_Y = 14;

            public static int PRODUCT_PRICE_X = 86;
            public static int PRODUCT_PRICE_Y = 36;

            public static int PRODUCT_QUANTITY_X = 86;
            public static int PRODUCT_QUANTITY_Y = 66;

            public static int PRODUCT_TOTAL_PRICE_X = 436;
            public static int PRODUCT_TOTAL_PRICE_Y = 66;

            public static int PRODUCT_CANCEL_BTN_X = 480;
            public static int PRODUCT_CANCEL_BTN_Y = 8;
            public static int PRODUCT_CANCEL_BTN_WIDTH = 24;
            public static int PRODUCT_CANCEL_BTN_HEIGHT = 19;
            public static void CHANGE_TEXT(Button basketBtn, int num)
            {
                basketBtn.Text = "Basket (" + num.ToString() + ')';
            }
        }

    }

    
}

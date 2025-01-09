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
            public static int PADDING_X = 50;
            public static int PADDING_Y = 50;
            public static int START_X = 33;
            public static int START_Y = 161;
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
        }

    }

    
}

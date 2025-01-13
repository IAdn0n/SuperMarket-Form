using System;
using System.IO;
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
            public const int WIDTH = 960;
            public const int HEIGHT = 640;
        }

        internal static class ProductSizes
        {
            public const int WIDTH = 133;
            public const int HEIGHT = 131;
            public const int PADDING_X = 30;
            public const int PADDING_Y = 50;
            public const int START_X = 20;
            public const int START_Y = 16;
            public const int FONT_SIZE = 10;

            public const int IMAGE_WIDTH = 120;
            public const int IMAGE_HEIGHT = 90;
            public const int IMAGE_X = 6;
            public const int IMAGE_Y = 31;


            public const int PRICE_X = 75;
            public const int PRICE_Y = 0;
            
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
            public const int PRODUCT_X = 8;
            public const int PRODUCT_Y = 18;
            public const int PRODUCT_WIDTH = 510;
            public const int PRODUCT_HEIGHT = 95;
            public const int PRODUCT_FONT_SIZE = 12;

            public const int PRODUCT_PICTURE_X = 10;
            public const int PRODUCT_PICTURE_Y = 16;
            public const int PRODUCT_PICTURE_WIDTH = 72;
            public const int PRODUCT_PICTURE_HEIGHT = 68;

            public const int PRODUCT_NAME_X = 86;
            public const int PRODUCT_NAME_Y = 14;

            public const int PRODUCT_PRICE_X = 86;
            public const int PRODUCT_PRICE_Y = 36;

            public const int PRODUCT_QUANTITY_X = 86;
            public const int PRODUCT_QUANTITY_Y = 66;

            public const int PRODUCT_TOTAL_PRICE_X = 436;
            public const int PRODUCT_TOTAL_PRICE_Y = 66;

            public const int PRODUCT_CANCEL_BTN_X = 480;
            public const int PRODUCT_CANCEL_BTN_Y = 8;
            public const int PRODUCT_CANCEL_BTN_WIDTH = 24;
            public const int PRODUCT_CANCEL_BTN_HEIGHT = 19;
            public static void CHANGE_TEXT(Button basketBtn, int num)
            {
                basketBtn.Text = "Basket (" + num.ToString() + ')';
            }
        }

        internal static class FileMethods
        {
            public const string USER_FILE = "UsersFile.txt";
            public const string PRODUCT_FILE = "ProductsFile.txt";
            public const string RECEIPT_FILE = "ReceiptsFile.txt";
            public const string RECEIPT_PRODUCT_FILE = "ReceiptProductFile.txt";
            public static int GetFileSize(string filePath)
            {
                int lineCount = 0;
                using (var reader = File.OpenText(filePath)) 
                    while (reader.ReadLine() != null)
                        lineCount++;
                    
                return lineCount;
            }
        }

    }

    
}

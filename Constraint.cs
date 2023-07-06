using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanSach
{
    public class Constraint
    {
        public static void blockInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        public static void Print(GroupBox groupbox)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true; // Xét tờ in nằm ngang
            printDocument.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(groupbox.Width, groupbox.Height, groupbox.CreateGraphics());
                groupbox.DrawToBitmap(bitmap, new Rectangle(0, 0, groupbox.Width, groupbox.Height));
                e.Graphics.DrawImage(bitmap, new Point(100, 100)); // Thay đổi vị trí in tùy ý
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public static void PrintPanel(Panel panel)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true; // Xét tờ in nằm ngang
            printDocument.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(panel.Width, panel.Height, panel.CreateGraphics());
                panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));
                e.Graphics.DrawImage(bitmap, new Point(100, 100)); // Thay đổi vị trí in tùy ý
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}

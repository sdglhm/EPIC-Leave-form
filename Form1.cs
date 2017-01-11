using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PaperSize paperSize = new PaperSize("A5 (148 x 210 mm)", 827, 584);
            printDocument1.DefaultPageSettings.PaperSize = paperSize;
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            button1.Visible = false;
            
            //Add a Panel control.
           // Panel panel = new Panel();
            //Controls.Add(panel);
            
            
            
            //Create a Bitmap of size same as that of the Form.
            Graphics grp = this.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);

            //Copy screen area that that the Panel covers.
            Point panelLocation = PointToScreen(new Point(0,0));
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
          
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, -10, -10, 827, 584);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

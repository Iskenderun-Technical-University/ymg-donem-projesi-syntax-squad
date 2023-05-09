using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NOTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            var sa = new SaveFileDialog();
            sa.Filter = "Text files |*.txt";
            sa.FileName = "TXT" + ".txt";
            var result = sa.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(sa.FileName, richTextBox1.Text);
            }

        }

        private void but2_Click(object sender, EventArgs e)
        {
            var sa = new OpenFileDialog();
            sa.Filter = "Text files |*.txt";
            sa.FileName = "TXT" + ".txt";
            var result = sa.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text= File.ReadAllText(sa.FileName);
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.Text);
        }

        private void but4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text =richTextBox1.Text + Clipboard.GetText();
        }

        private void but5_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            catch
            {

            }
          
        }

        private void but6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text,richTextBox1.Font,Brushes.Brown,new Point(100,100));
        }
    }
}

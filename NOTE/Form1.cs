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

        private void but7_Click(object sender, EventArgs e)
        {
            var yaz =new FontDialog();
            var sol = yaz.ShowDialog();

            if (sol == DialogResult.OK)
            {
                richTextBox1.Font = yaz.Font;
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void but8888_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void but10_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.No;

        }

        private void but11_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }

        private void but12_Click(object sender, EventArgs e)
        {
            var backrg = new ColorDialog();
            var rol = backrg.ShowDialog();

            if (rol == DialogResult.OK)
            {
                richTextBox1.BackColor = backrg.Color;

            }
        }

        private void but13_Click(object sender, EventArgs e)
        {
            var backrg = new ColorDialog();
            var rol = backrg.ShowDialog();

            if (rol == DialogResult.OK)
            {
                richTextBox1.ForeColor = backrg.Color;

            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.ZoomFactor = Slider1.Value;
            }
            catch
            {

            }
           
        }
    }
}

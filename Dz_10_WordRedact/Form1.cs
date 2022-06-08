using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_10_WordRedact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            KeyPreview = true;
            InitializeComponent();
        }
          
        private void toolStripЖClick(object sender, EventArgs e)
        {  
            Font f1 = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Bold);
            richTextBox1.SelectionFont = f1;
        }

        private void toolStripK_Click(object sender, EventArgs e)
        {
            Font f1 = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Italic);
            richTextBox1.SelectionFont = f1;
        }

        private void toolStripЧ_Click(object sender, EventArgs e)
        {
            Font f1 = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, FontStyle.Underline);
            richTextBox1.SelectionFont = f1;
        }
         

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily f;
            if (toolStripComboBox1.Text == "Times New Roman")
            {
                f = new FontFamily("Times New Roman");
                Font f1 = new Font(f, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                richTextBox1.SelectionFont = f1;
            }
            if (toolStripComboBox1.Text == "Calibri")
            {
                f = new FontFamily("Calibri");
                Font f1 = new Font(f, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                richTextBox1.SelectionFont = f1;
            }
            if (toolStripComboBox1.Text == "Arial")
            {
                f = new FontFamily("Arial");
                Font f1 = new Font(f, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                richTextBox1.SelectionFont = f1;
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            int x = 10;
            switch (toolStripComboBox2.Text)
            {
                case "2": x = 2; break;
                case "4": x = 4; break;
                case "6": x = 6; break;
                case "8": x = 8; break;
                case "10": x = 10; break;
                case "12": x = 12; break;
                case "14": x = 14; break;
                case "16": x = 16; break;
                case "18": x = 18; break;
                case "20": x = 20; break;
                case "22": x = 22; break;
                case "24": x = 24; break;
                default: break;
            } 
            Font f1 = new Font(richTextBox1.SelectionFont.FontFamily, x, richTextBox1.SelectionFont.Style);
            richTextBox1.SelectionFont = f1; 
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripComboBox2.SelectedIndex++;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            toolStripComboBox2.SelectedIndex--;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        { 
            SendKeys.Send("^С");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SendKeys.Send("^V");
        }
    }
}

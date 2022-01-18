using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IESLab2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            /*searcher = new Searcher();
            searcher.Start();*/
        }

        
        private void WidthButton_Click(object sender, EventArgs e)
             {
                 OutputField.Text = "";
                 Searcher searcher = new Searcher();
                 searcher.Start();     
                 try
                 {
                      searcher.WidthSearch();
              //  searcher.DepthSearch(8);
                 }
                 catch(Exception error)
                 {
                     OutputField.Text += error.Message + "\r\n";
                 }
                 foreach (var item in searcher.GetPath())
                 {
                     OutputField.Text += item + "\r\n";
                 }
                 Steps.Text = searcher.Steps.ToString();
             }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (LimitBox.Checked)
            {
                LimitationPanel.Visible = true;
            }
            else
            {
                Level.Text = "100";
                LimitationPanel.Visible = false;
            }
        }

        private void Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DepthButton_Click(object sender, EventArgs e)
        {
            OutputField.Text = "";
            Searcher searcher = new Searcher();
            searcher.Start();
            try
            {
                  searcher.DepthSearch(Convert.ToInt32(Level.Text));
            }
            catch (Exception error)
            {
                OutputField.Text += error.Message + "\r\n";
            }
            foreach (var item in searcher.GetPath())
            {
                OutputField.Text += item + "\r\n";
            }
            Steps.Text = searcher.Steps.ToString();
        }
    }
}

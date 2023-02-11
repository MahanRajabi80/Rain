using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------
        const int TEDAD = 150;
        Label[] lblRain = new Label[TEDAD];
        //--------------------------------------------------------------------------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
        //--------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < TEDAD; i++)
            {
                lblRain[i] = new Label();
                lblRain[i].Left = r.Next(this.Width);
                lblRain[i].Top = r.Next(this.Height);
                lblRain[i].ForeColor = Color.White;
                lblRain[i].Text = "|";
                this.Controls.Add(lblRain[i]);
            }
        }
        //--------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < TEDAD; i++)
            {
                lblRain[i].Top += 50;
                if (lblRain[i].Top > this.Height)
                {
                    Random r = new Random();
                    lblRain[i].Left = r.Next(this.Width);
                    lblRain[i].Top = r.Next(50);
                }
            }
        }        
    }
}

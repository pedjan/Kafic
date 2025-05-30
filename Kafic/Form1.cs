using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kafic
{
    public partial class Form1 : Form
    {
        bool dragging;
        int xoffset;
        int yoffset;

        public Form1()
        {
            InitializeComponent();
            dragging = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b;
            b = (Button)sender;
            if (Control.ModifierKeys == Keys.Control)
            {
                dragging = true;
                xoffset = e.X;
                yoffset = e.Y;
                //textBox1.AppendText($"\r\nButtonDown-CTRL.\r\nx={e.X}, y={e.Y}");
        
    }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button b;
            int XMoved;
            int YMoved;
            int newBtnX;
            int newBtnY;

            b = (Button)sender;
            if (dragging)
            {
                XMoved = e.Location.X - xoffset;
                YMoved = e.Location.Y - yoffset;

                newBtnX = b.Location.X + XMoved;
                newBtnY = b.Location.Y + YMoved;

                //X
                if (newBtnX <= 0)
                {
                    newBtnX = b.Location.X;
                }
                else if (newBtnX + b.Height >= this.ClientSize.Height)
                {
                    newBtnX = b.Location.X;
                }

                //Y
                if (newBtnY <= 0)
                {
                    newBtnY = b.Location.Y;
                }
                else if (newBtnY + b.Height >= this.ClientSize.Height)
                {
                    newBtnY = b.Location.Y;
                }
                b.Location = new Point(newBtnX, newBtnY);
            }
        }

        //private void button1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    textBox1.AppendText($"\r\nForm1_MouseDown.\r\nx={e.X}, y={e.Y}");
        //}
    }
}

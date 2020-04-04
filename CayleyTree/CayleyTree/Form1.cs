using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        int n ;
        double th1 = 30 * Math.PI/180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        

        public Form1()
        {
            InitializeComponent();
        }
       

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            th1 = Convert.ToDouble(ThRValue.Text) * Math.PI / 180;
            th2 = Convert.ToDouble(Th2Value.Text) * Math.PI / 180;
            per1 = Convert.ToDouble(per1Value.Text);
            per2 = Convert.ToDouble(per2Value.Text);

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            Color penColor = new Color();
            switch (comboBoxColor.Text)
            {
                case "红色" :
                    penColor = Color.Red;
                    break;
                case "绿色":
                    penColor = Color.Green;
                    break;
                case "蓝色":
                    penColor = Color.Blue;
                    break;
                case "黑色":
                    penColor = Color.Black;
                    break;
                case "褐色":
                    penColor = Color.Brown;
                    break;
                case "紫色":
                    penColor = Color.Purple;
                    break;
                default:
                    penColor = Color.Pink;
                    break;
            }
            Pen pen = new Pen(penColor);
            Graphics graphics = drawPanel1.CreateGraphics();
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics graphics = drawPanel1.CreateGraphics();
            graphics.Clear(Color.White);
            n = Convert.ToInt32(nValue.Text);
            drawCayleyTree(n, drawPanel1.Location.X+drawPanel1.Width/2, drawPanel1.Location.Y + drawPanel1.Height, Convert.ToInt32(lengValue.Text), -Math.PI / 2);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trb_nValue_Scroll(object sender, EventArgs e)
        {
            nValue.Text = Convert.ToString(trb_nValue.Value);
        }

        private void trbLeng_Scroll(object sender, EventArgs e)
        {
            lengValue.Text = Convert.ToString(trbLeng.Value);
        }

        private void trbPer1_Scroll(object sender, EventArgs e)
        {
            per1Value.Text = Convert.ToString(trbPer1.Value*0.01);
        }

        private void trbPer2_Scroll(object sender, EventArgs e)
        {
            per2Value.Text = Convert.ToString(trbPer2.Value*0.01);
        }

        private void trbTh1_Scroll(object sender, EventArgs e)
        {
            ThRValue.Text = Convert.ToString(trbTh1.Value);
        }

        private void trbTh2_Scroll(object sender, EventArgs e)
        {
            Th2Value.Text = Convert.ToString(trbTh2.Value);
        }
    }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。
 * 参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、
 * 左分支长度比（per2）、右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。
*/

namespace homework7
{
    public partial class Form1 : Form
    {
         
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Red;
        int depth = 10;
        double length = 100;

        public Form1()
        {
            InitializeComponent();
            textdeepth.Text = "10";
            textlength.Text = "100";
            textLper.Text = "0.6";
            textRper.Text = "0.7";
            textLth.Text = "0.523";
            textRth.Text = "0.349";

        }

        void drawCayleyTree(int n,double x0, double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0,double x1,double y1)
        {
            graphics.DrawLine(
            pen,
            (int)x0, (int)y0, (int)x1, (int)y1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(panel1.BackColor);
            switch (pencolor.Text)
            {
                case "红色": pen = Pens.Red; break;
                case "黄色": pen = Pens.Yellow; break;
                case "绿色": pen = Pens.Green; break;
                case "蓝色": pen = Pens.Blue; break;
                case "黑色": pen = Pens.Black; break;
                default: pen = Pens.Red; break;
            }
            try
            {
                depth = Convert.ToInt32(textdeepth.Text);
                length = Convert.ToDouble(textlength.Text);
                per1 = Convert.ToDouble(textLper.Text);
                per2 = Convert.ToDouble(textRper.Text);
                th1 = Convert.ToDouble(textLth.Text);
                th2 = Convert.ToDouble(textRth.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("输入错误，请重新输入！");
            }
            if (graphics == null) graphics = panel1.CreateGraphics();
            drawCayleyTree(depth, 200, 310, length, -Math.PI / 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

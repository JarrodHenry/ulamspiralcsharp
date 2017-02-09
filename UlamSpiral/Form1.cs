using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UlamSpiral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var scale = Convert.ToInt32(numericUpDown2.Value);
            var pn = new PrimeNumbers();
            var result = pn.MakeSieve(Convert.ToInt32(numericUpDown1.Value));
            var graphics = panel1.CreateGraphics();
            graphics.Clear(Color.White);
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.Black);
            SolidBrush centerColor = new System.Drawing.SolidBrush(Color.Red);
            int panelCenterX = (panel1.Right - panel1.Left) / 2;
            int panelCenterY = (panel1.Bottom - panel1.Top) / 2;
            //graphics.FillRectangle(brush, new Rectangle(panelCenterX, panelCenterY, 1,1));
            
            for (int x = 0; x<result.Length; x++)
            {
                if (result[x])
                {
                    var coordinate = pn.CalculatePointByIndex(x);
                    int xPos = (coordinate.Item1*scale);
                    int yPos = (coordinate.Item2*scale);

                    graphics.FillRectangle(brush, new Rectangle(panelCenterX+xPos, panelCenterY+yPos, scale, scale));
                }
            }
            graphics.FillRectangle(centerColor, new Rectangle(panelCenterX, panelCenterY, scale, scale));
          
        }

  
    }
}

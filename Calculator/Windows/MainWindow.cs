using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Windows
{
    class MainWindow : Form
    {
        private const int WIDTH = 320;
        private const int HEIGHT = 430;
        private const int MARGIN_HORIZONTAL = 8;
        private const int MARGIN_VERTICAL = 16;

        public MainWindow()
        {
            Label labArithExpression = new Label
            {
                Text = "5 + 6",
                Font = new System.Drawing.Font("Times New Roman",
                    15.0f, System.Drawing.FontStyle.Regular),
                Location = new System.Drawing.Point(8, 15)
            };
            Label labResult = new Label
            {
                Text = "11",
                Font = new System.Drawing.Font("Times New Roman",
                    20.0f, System.Drawing.FontStyle.Regular),
                Location = new System.Drawing.Point(5, 45)
            };

            

            var size = new System.Drawing.Size(
                WIDTH + 2 * MARGIN_HORIZONTAL, 
                HEIGHT + 2 * MARGIN_VERTICAL);

            this.Size = size;
            this.MinimumSize = size;
            this.MaximumSize = size;
            this.Controls.Add(labArithExpression);
            this.Controls.Add(labResult);
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);
            this.Controls.Add(btn9);
            this.Controls.Add(btn10);
            this.Controls.Add(btn11);
            this.Controls.Add(btn12);
            this.Controls.Add(btn13);
            this.Controls.Add(btn14);
            this.Controls.Add(btn15);
            this.Controls.Add(btn16);
            this.Controls.Add(btn17);
            this.Controls.Add(btn18);
            this.Controls.Add(btn20);

        }
        
    }

}

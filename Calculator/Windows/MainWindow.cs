using Calculator.Classes;
using Calculator.Properties;
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
                Text = "",
                Size = new Size(WIDTH - MARGIN_HORIZONTAL * 2, 20),
                Font = new System.Drawing.Font("Times New Roman",
                    15.0f, System.Drawing.FontStyle.Regular),
                Location = new System.Drawing.Point(MARGIN_HORIZONTAL, 15),
                ForeColor = Color.White
            };

            Label labResult = new Label
            {
                Text = "",
                Size = new Size(WIDTH - MARGIN_HORIZONTAL * 2, 33),
                Font = new System.Drawing.Font("Times New Roman",
                    20.0f, System.Drawing.FontStyle.Regular),
                Location = new System.Drawing.Point(MARGIN_HORIZONTAL, 45),
                ForeColor = Color.White
            };

            Buttons buttons = new Buttons(labArithExpression, labResult, this);

            var screenSize = new System.Drawing.Size(
                WIDTH + 2 * MARGIN_HORIZONTAL, 
                HEIGHT + 2 * MARGIN_VERTICAL);

            this.Size = screenSize;
            this.MinimumSize = screenSize;
            this.MaximumSize = screenSize;

            this.BackColor = Color.FromArgb(51, 51, 51);

            this.Controls.Add(labArithExpression);
            this.Controls.Add(labResult);
            

        }
        
    }

}

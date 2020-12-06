using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    class Buttons {
  
        public Buttons(int screenWith, 
            int marginHorizontal,
            int marginVertical)
        {
            var btnWidth = (int)(WIDTH - MARGIN_HORIZONTAL * 5) / 4;
            var btnHeight = (int)(0.7 * btnWidth);
            var btnStartOffsetY = 86;

            Button btn1 = new Button
            {
                Text = "%",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    MARGIN_HORIZONTAL,
                    btnStartOffsetY
                )
            };

            Button btn2 = new Button
            {
                Text = "-",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    2 * MARGIN_HORIZONTAL + btnWidth,
                    btnStartOffsetY
                )
            };

            Button btn3 = new Button
            {
                Text = "+",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    3 * MARGIN_HORIZONTAL + 2 * btnWidth,
                    btnStartOffsetY
                )
            };


            var iconDel = Image.FromFile(@"C:\Users\Dmitry\source\repos\Calculator\Calculator\Icons\del.png");
            var iconDelNewSize = new Bitmap(iconDel, iconDel.Width / 2, iconDel.Height / 2);

            Button btn4 = new Button
            {
                Image = iconDelNewSize,
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    4 * MARGIN_HORIZONTAL + 3 * btnWidth,
                    btnStartOffsetY
                )
            };

            Button btn5 = new Button
            {
                Text = "7",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    MARGIN_HORIZONTAL,
                    btnStartOffsetY + btnHeight + MARGIN_VERTICAL
                )
            };

            Button btn6 = new Button
            {
                Text = "8",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    2 * MARGIN_HORIZONTAL + btnWidth,
                    btnStartOffsetY + btnHeight + MARGIN_VERTICAL
                )
            };

            Button btn7 = new Button
            {
                Text = "9",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    3 * MARGIN_HORIZONTAL + 2 * btnWidth,
                    btnStartOffsetY + btnHeight + MARGIN_VERTICAL
                )
            };

            Button btn8 = new Button
            {
                Text = "*",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                    4 * MARGIN_HORIZONTAL + 3 * btnWidth,
                    btnStartOffsetY + btnHeight + MARGIN_VERTICAL)
            };

            Button btn9 = new Button
            {
                Text = "4",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                   MARGIN_HORIZONTAL,
                   btnStartOffsetY + btnHeight * 2 + MARGIN_VERTICAL * 2)
            };

            Button btn10 = new Button
            {
                Text = "5",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                   2 * MARGIN_HORIZONTAL + btnWidth,
                   btnStartOffsetY + btnHeight * 2 + MARGIN_VERTICAL * 2)
            };

            Button btn11 = new Button
            {
                Text = "6",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                   3 * MARGIN_HORIZONTAL + 2 * btnWidth,
                   btnStartOffsetY + btnHeight * 2 + MARGIN_VERTICAL * 2)
            };

            Button btn12 = new Button
            {
                Text = "/",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                               4 * MARGIN_HORIZONTAL + 3 * btnWidth,
                               btnStartOffsetY + btnHeight * 2 + MARGIN_VERTICAL * 2)
            };


            Button btn13 = new Button
            {
                Text = "1",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                   MARGIN_HORIZONTAL,
                   btnStartOffsetY + btnHeight * 3 + MARGIN_VERTICAL * 3)
            };

            Button btn14 = new Button
            {
                Text = "2",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                   2 * MARGIN_HORIZONTAL + btnWidth,
                   btnStartOffsetY + btnHeight * 3 + MARGIN_VERTICAL * 3)
            };

            Button btn15 = new Button
            {
                Text = "3",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                   3 * MARGIN_HORIZONTAL + 2 * btnWidth,
                   btnStartOffsetY + btnHeight * 3 + MARGIN_VERTICAL * 3)
            };

            Button btn16 = new Button
            {
                Text = "%",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                               4 * MARGIN_HORIZONTAL + 3 * btnWidth,
                               btnStartOffsetY + btnHeight * 3 + MARGIN_VERTICAL * 3)
            };

            Button btn17 = new Button
            {
                Text = "0",
                Size = new System.Drawing.Size(btnWidth * 2 + MARGIN_HORIZONTAL, btnHeight),
                Location = new System.Drawing.Point(
                               MARGIN_HORIZONTAL,
                               btnStartOffsetY + btnHeight * 4 + MARGIN_VERTICAL * 4)
            };

            Button btn18 = new Button
            {
                Text = ",",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                               3 * MARGIN_HORIZONTAL + 2 * btnWidth,
                               btnStartOffsetY + btnHeight * 4 + MARGIN_VERTICAL * 4)
            };

            Button btn20 = new Button
            {
                Text = "=",
                Size = new System.Drawing.Size(btnWidth, btnHeight),
                Location = new System.Drawing.Point(
                               4 * MARGIN_HORIZONTAL + 3 * btnWidth,
                               btnStartOffsetY + btnHeight * 4 + MARGIN_VERTICAL * 4)
            };
        }
    
    }
}

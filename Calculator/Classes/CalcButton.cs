using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes
{
    class CalcButton : Button
    {
        private Color btnDarkColor = Color.FromArgb(95, 94, 99);

        public CalcButton(string name, string text,
            int btnWidth, int btnHeight, 
            EventHandler handler,
            Point location)
        {
            Name = name;
            Text = text;
            FlatStyle = FlatStyle.Flat;
            BackColor = btnDarkColor;
            Size = new System.Drawing.Size(btnWidth, btnHeight);
            Location = location;
            Click += handler;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;
        }
    }
}

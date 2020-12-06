using Calculator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes
{
    class Buttons {
  
        private int btnWidth;
        private int btnHeight;
        private int btnStartOffsetY;

        private Thread threadHolder;

        private System.Resources.ResourceManager RM =
              new System.Resources.ResourceManager("Calculator.Properties.Resources", typeof(Resources).Assembly);

        private Label labExpression;
        private Label labResult;

        private string firstNumber = "";
        private string secondNumber = "";
        private char signOperation = ' ';

        private int screenWidth;
        private int marginHorizontal;
        private int marginVertical;

        private EventHandler eventHandlerClick;

        private Form parent;

        public Buttons(
            Label labExpression,
            Label labResult,
            Form parent,
            int screenWidth = 320, 
            int marginHorizontal = 8,
            int marginVertical = 16,
            int btnStartOffsetY = 100)
        {

            this.labExpression = labExpression;
            this.labResult = labResult;
            this.screenWidth = screenWidth;
            this.marginHorizontal = marginHorizontal;
            this.marginVertical = marginVertical;

            this.btnWidth = (int) (screenWidth - marginHorizontal * 5) / 4;
            this.btnHeight = (int) (0.7 * btnWidth);
            this.btnStartOffsetY = btnStartOffsetY;

            this.eventHandlerClick = new EventHandler(btnClickToCalculate);

            this.parent = parent;

            makeFirstRow();
            makeSecondRow();
            makeThirdRow();
            makeFourthRow();
            makeFirthRow();
        }

        private void btnClickToCalculate(object sender, EventArgs args)
        {
            var btn = sender as Button;
            switch (btn.Name)
            {
                case "btnRemaind":
                case "btnMinus":
                case "btnPlus":
                case "btnMul":
                case "btnDiv":
                    if (!this.firstNumber.Equals(""))
                    {
                        this.signOperation = btn.Text[0];
                    }
                    break;

                case "btnDel":
                    
                    var exprText = labExpression.Text;
                    if (!this.secondNumber.Equals(""))
                    {
                        this.secondNumber = this.secondNumber.Substring(0, this.secondNumber.Length - 1);
                    } else if (signOperation != ' ')
                    {
                        signOperation = ' ';
                    } else if (!this.firstNumber.Equals(""))
                    {
                        this.firstNumber = this.firstNumber.Substring(0, this.firstNumber.Length - 1);
                    }
                    
                    break;

                case "btnSeven":
                case "btnEight":
                case "btnNine":
                case "btnFour":
                case "btnFive":
                case "btnSix":
                case "btnOne":
                case "btnTwo":
                case "btnThree":
                    if (this.signOperation != ' ')
                    {
                        this.secondNumber += btn.Text;
                    }
                    else
                    {
                        this.firstNumber += btn.Text;
                    }
                    break; 
                case "btnNothing":
                    break;
                case "btnZero":
                    if (this.signOperation != ' ')
                    {
                        if ((this.secondNumber.Length == 1 &&
                            this.secondNumber[0] != '0') || this.secondNumber.Length != 1)
                        {
                            this.secondNumber += btn.Text;
                        }
                    } else
                    {
                        if ((this.firstNumber.Length == 1 &&
                            this.firstNumber[0] != '0') || this.firstNumber.Length != 1)
                        {
                            this.firstNumber += btn.Text;
                        }
                    }
                    break;
                case "btnComma":
                    if (this.signOperation != ' ' && !this.secondNumber.Equals("") &&
                        !this.secondNumber.Contains(","))
                    {
                        this.secondNumber += btn.Text;
                    }
                    else if (!this.firstNumber.Equals("") && this.signOperation == ' ' &&
                        !this.firstNumber.Contains(","))
                    {
                        this.firstNumber += btn.Text;
                    }
                    break;
                case "btnEquals":
                    labResult.Text = Utils.runOperation(this.firstNumber, 
                        this.secondNumber, this.signOperation).ToString();
                    break;
            }
            labExpression.Text = (
                this.firstNumber + " " +
                this.signOperation + " " +
                this.secondNumber);
        }

        private void btnDelMouseDown(object sender, MouseEventArgs args)
        {
            threadHolder = new Thread(() =>
            {
                Thread.Sleep(600);
                clearExpression();
            });
            threadHolder.Start();
        }

        private void btnDelMouseUp(object sender, MouseEventArgs args)
        {
            if (threadHolder != null)
            {
                threadHolder.Abort();
                threadHolder = null;
            }
        }

        private void clearExpression()
        {
            this.firstNumber = "";
            this.secondNumber = "";
            this.signOperation = ' ';
        }

        private void makeFirstRow()
        {
            Button btnRemaind = new CalcButton(
                "btnRemaind", "%", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(marginHorizontal, btnStartOffsetY
            ));

            Button btnMinus = new CalcButton(
                "btnMinus", "-", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                    2 * marginHorizontal + btnWidth, 
                    btnStartOffsetY
                )
            );

            Button btnPlus = new CalcButton(
                "btnPlus", "+", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                    3 * marginHorizontal + 2 * btnWidth,
                    btnStartOffsetY
                )
            );

            var img = (Image) RM.GetObject("del");
            var imgNewSize = new Bitmap(img, img.Width / 2, img.Height / 2);

            Button btnDel = new CalcButton(
                "btnDel", "", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                    4 * marginHorizontal + 3 * btnWidth,
                    btnStartOffsetY
                )
            );

            btnDel.Image = imgNewSize;
            btnDel.MouseDown += new MouseEventHandler(btnDelMouseDown);
            btnDel.MouseUp += new MouseEventHandler(btnDelMouseUp);

            this.parent.Controls.Add(btnRemaind);
            this.parent.Controls.Add(btnPlus);
            this.parent.Controls.Add(btnMinus);
            this.parent.Controls.Add(btnDel);
        }

        private void makeSecondRow()
        {
            Button btnSeven = new CalcButton(
                "btnSeven", "7", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                    marginHorizontal,
                    btnStartOffsetY + btnHeight + marginVertical
                )
            );

            Button btnEight = new CalcButton(
                "btnEight", "8", btnWidth, btnHeight, this.eventHandlerClick,
                 new System.Drawing.Point(
                    2 * marginHorizontal + btnWidth,
                    btnStartOffsetY + btnHeight + marginVertical
                )
            );

            Button btnNine = new CalcButton(
                "btnNine", "9", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                    3 * marginHorizontal + 2 * btnWidth,
                    btnStartOffsetY + btnHeight + marginVertical
                )
            );

            Button btnMul = new CalcButton(
                "btnMul", "x", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                    4 * marginHorizontal + 3 * btnWidth,
                    btnStartOffsetY + btnHeight + marginVertical
                )
            );

            this.parent.Controls.Add(btnSeven);
            this.parent.Controls.Add(btnEight);
            this.parent.Controls.Add(btnNine);
            this.parent.Controls.Add(btnMul);
        }

        private void makeThirdRow()
        {
            Button btnFour = new CalcButton(
               "btnFour", "4", btnWidth, btnHeight, this.eventHandlerClick,
               new System.Drawing.Point(
                   marginHorizontal,
                   btnStartOffsetY + btnHeight * 2 + marginVertical * 2
               )
            );

            Button btnFive = new CalcButton(
              "btnFive", "5", btnWidth, btnHeight, this.eventHandlerClick,
               new System.Drawing.Point(
                   2 * marginHorizontal + btnWidth,
                   btnStartOffsetY + btnHeight * 2 + marginVertical * 2
               )
            );

            Button btnSix = new CalcButton(
              "btnSix", "6", btnWidth, btnHeight, this.eventHandlerClick,
               new System.Drawing.Point(
                   3 * marginHorizontal + 2 * btnWidth,
                   btnStartOffsetY + btnHeight * 2 + marginVertical * 2
               )
            );

            Button btnDiv = new CalcButton(
              "btnDiv", "/", btnWidth, btnHeight, this.eventHandlerClick,
               new System.Drawing.Point(
                  4 * marginHorizontal + 3 * btnWidth,
                  btnStartOffsetY + btnHeight * 2 + marginVertical * 2
               )
            );

            this.parent.Controls.Add(btnFour);
            this.parent.Controls.Add(btnFive);
            this.parent.Controls.Add(btnSix);
            this.parent.Controls.Add(btnDiv);
        }
        
        private void makeFourthRow()
        {
            Button btnOne = new CalcButton(
                "btnOne", "1", btnWidth, btnHeight, this.eventHandlerClick,
                new System.Drawing.Point(
                   marginHorizontal,
                   btnStartOffsetY + btnHeight * 3 + marginVertical * 3
                )
            );

            Button btnTwo = new CalcButton(
                "btnTwo", "2", btnWidth, btnHeight, this.eventHandlerClick,
                 new System.Drawing.Point(
                    2 * marginHorizontal + btnWidth,
                    btnStartOffsetY + btnHeight * 3 + marginVertical * 3
                 )
            );

            Button btnThree = new CalcButton(
                "btnThree", "3", btnWidth, btnHeight, this.eventHandlerClick,
                 new System.Drawing.Point(
                   3 * marginHorizontal + 2 * btnWidth,
                   btnStartOffsetY + btnHeight * 3 + marginVertical * 3
                 )
            );

            this.parent.Controls.Add(btnOne);
            this.parent.Controls.Add(btnTwo);
            this.parent.Controls.Add(btnThree);
        }
       
        private void makeFirthRow()
        {
            Button btnZero = new CalcButton(
                "btnZero", "0", btnWidth * 2 + marginHorizontal, btnHeight, this.eventHandlerClick,
                 new System.Drawing.Point(
                    marginHorizontal,
                    btnStartOffsetY + btnHeight * 4 + marginVertical * 4
                 )
            );

            Button btnComma = new CalcButton(
                "btnComma", ",", btnWidth, btnHeight, this.eventHandlerClick,
                 new System.Drawing.Point(
                    3 * marginHorizontal + 2 * btnWidth,
                    btnStartOffsetY + btnHeight * 4 + marginVertical * 4
                 )
            );

            Button btnEquals = new CalcButton(
                "btnEquals", "=", btnWidth, btnHeight * 2 + marginVertical, this.eventHandlerClick,
                 new System.Drawing.Point(
                    4 * marginHorizontal + 3 * btnWidth,
                    btnStartOffsetY + btnHeight * 3 + marginVertical * 3
                 )
            );

            this.parent.Controls.Add(btnZero);
            this.parent.Controls.Add(btnComma);
            this.parent.Controls.Add(btnEquals);
        }
    }
}

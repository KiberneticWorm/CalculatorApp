using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes
{
    class Utils
    {
        public static double runOperation(string strFirstNum, string strSecondNum, 
            char signOperation)
        {
            double firstNumber;
            double secondNumber;
            if (Double.TryParse(strFirstNum, out firstNumber) &&
                Double.TryParse(strSecondNum, out secondNumber))
            {
                switch (signOperation)
                {
                    case '-':
                        return firstNumber - secondNumber;
                    case '*':
                        return firstNumber * secondNumber;
                    case '/':
                        return firstNumber / secondNumber;
                    case '%':
                        return firstNumber % secondNumber;
                    case '+':
                        return firstNumber + secondNumber;
                    default:
                        return 0;
                }
            }
            return 0;
        }
    }
}

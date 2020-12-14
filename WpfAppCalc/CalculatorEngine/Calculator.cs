using System.Reflection;
using System;
using System.Globalization;

namespace Calculator
{



    public class CalcEngine
    {
        static IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
        //
        // Operation Constants.
        //
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            eExponentiation = 5,
            eSqrt = 6,
            eInv = 7,
            eSquar = 8,
            eFact = 9,
            eSqrtKub = 10
        }

        //
        // Module-Level Constants
        //

        private static double negativeConverter = -1;
        // TODO: Upgrade the version number to 3.0.1.1
        private static string versionInfo = "Calculator v3.0.1.1";

        //
        // Module-level Variables.
        //

        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;

        //
        // Class Constructor.
        //

        public CalcEngine()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }

        //
        // Returns the custom version string to the caller.
        //

        public static string GetVersion()
        {
            return (versionInfo);
        }
        //
        // Called when the Date key is pressed.
        //

        public static string GetDate()
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            return (stringAnswer);
        }

        //
        // Called when a number key is pressed on the keypad.
        //

        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer = stringAnswer + KeyNumber;
            return (stringAnswer);
        }

        //
        // Called when an operator is selected (+, -, *, /,exp)
        //

        public static void CalcOperation(Operator calcOper)
        {
            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = double.Parse(stringAnswer, formatter);
                calcOperation = calcOper;
                stringAnswer = "";
                decimalAdded = false;
            }
        }

        //
        // Called when an operator is selected (sqrt, squar, inv)
        //

        public static void CalcUnOperation(Operator calcOper)
        {
            if (stringAnswer != "")
            {
                firstNumber = double.Parse(stringAnswer, formatter);
                calcOperation = calcOper;
                decimalAdded = false;
                CalcEqual();
            }
        }

        //
        // Called when the +/- key is pressed.
        //

        public static string CalcSign()
        {
            double numHold;

            if (stringAnswer != "")
            {
                numHold = double.Parse(stringAnswer, formatter);
                stringAnswer = System.Convert.ToString(numHold * negativeConverter);
            }

            return (stringAnswer);
        }

        //
        // Called when the . key is pressed.
        //

        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != "")
                    stringAnswer = stringAnswer + ".";
                else
                    stringAnswer = "0.";

                decimalAdded = true;
            }

            return (stringAnswer);
        }

        //
        // Called when = is pressed.
        //

        public static string CalcEqual()
        {
            bool validEquation = false;

            if (stringAnswer != "")
            {
                secondNumber = double.Parse(stringAnswer, formatter); ;
                secondNumberAdded = true;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        validEquation = false;
                        break;

                    case Operator.eAdd:
                        numericAnswer = firstNumber + secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eSubtract:
                        numericAnswer = firstNumber - secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eMultiply:
                        numericAnswer = firstNumber * secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eDivide:
                        numericAnswer = firstNumber / secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eExponentiation:

                        numericAnswer = firstNumber;
                        for (int i = 1; i < secondNumber; i++)
                        {
                            numericAnswer *= firstNumber;
                        }
                        validEquation = true;
                        break;

                    case Operator.eSqrt:
                        numericAnswer = Math.Sqrt(firstNumber);
                        validEquation = true;
                        break;

                    case Operator.eSqrtKub:
                        numericAnswer = Math.Pow(firstNumber,1/3f) ;
                        validEquation = true;
                        break;


                    case Operator.eInv:
                        numericAnswer = 1 / firstNumber;
                        validEquation = true;
                        break;

                    case Operator.eSquar:
                        numericAnswer = firstNumber * firstNumber;
                        validEquation = true;
                        break;

                    case Operator.eFact:
                        numericAnswer = ((int)firstNumber == 0) ? 1 : (int)firstNumber * fact((int)firstNumber - 1); ;
                        validEquation = true;
                        break;


                    default:
                        validEquation = false;
                        break;
                }

                if (validEquation)
                    stringAnswer = System.Convert.ToString(numericAnswer);
            }

            return (stringAnswer);
        }

        //
        // Resets the various module-level variables for the next calculation.
        //

        public static void CalcReset()
        {
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            stringAnswer = "";
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }
        static int fact(int num)
        {
            return (num == 0) ? 1 : num * fact(num - 1);
        }
    }
}
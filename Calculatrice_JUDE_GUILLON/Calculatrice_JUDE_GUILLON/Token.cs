using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_JUDE_GUILLON
{
    class Token
    {
        public static int UNKNOWN = -1;
        public static int NUMBER = 0;
        public static int OPERATOR = 1;
        public static int LEFT_PARENTHESIS = 2;
        public static int RIGHT_PARENTHESIS = 3;

        private int type;
        private double value;
        private char operatorr;
        private int precedence;

        public Token()
        {
            type = UNKNOWN;
        }
        public Token(String contents)
        {
            switch (contents)
            {
                case "+":
                    type = OPERATOR;
                    operatorr = contents[0];
                    precedence = 1;
                    break;
                case "-":
                    type = OPERATOR;
                    operatorr = contents[0];
                    precedence = 1;
                    break;
                case "*":
                    type = OPERATOR;
                    operatorr = contents[0];
                    precedence = 2;
                    break;
                case "/":
                    type = OPERATOR;
                    operatorr = contents[0];
                    precedence = 2;
                    break;
                case "(":
                    type = LEFT_PARENTHESIS;
                    break;
                case ")":
                    type = RIGHT_PARENTHESIS;
                    break;
                default:
                    type = NUMBER;
                    try
                    {
                        value = Convert.ToDouble(contents);
                    }
                    catch (Exception ex)
                    {
                        type = UNKNOWN;
                    }
                    break;
            }
        }

        public Token(double x)
        {
            type = NUMBER;
            value = x;
        }

        public int getType() { return type; }
        public double getValue() { return value; }
        public int getPrecedence() { return precedence; }

        public Token operate(double a, double b)
        {
            double result = 0;
            switch (operatorr)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                        return new Token("Erreur");
                    result = a / b;
                    break;
            }
            return new Token(result);
        }
    }
}
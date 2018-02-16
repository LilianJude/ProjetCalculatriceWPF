﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static String ERROR = "Erreur";
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }


        //********************* EVENTS *********************//

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1)
            {
                ((ViewModel)DataContext).Result += "1";
            }

            if (e.Key == Key.NumPad2)
            {
                ((ViewModel)DataContext).Result += "2";
            }

            if (e.Key == Key.NumPad3)
            {
                ((ViewModel)DataContext).Result += "3";
            }

            if (e.Key == Key.NumPad4)
            {
                ((ViewModel)DataContext).Result += "4";
            }

            if (e.Key == Key.NumPad5)
            {
                ((ViewModel)DataContext).Result += "5";
            }

            if (e.Key == Key.NumPad6)
            {
                ((ViewModel)DataContext).Result += "6";
            }

            if (e.Key == Key.NumPad7)
            {
                ((ViewModel)DataContext).Result += "7";
            }

            if (e.Key == Key.NumPad8)
            {
                ((ViewModel)DataContext).Result += "8";
            }

            if (e.Key == Key.NumPad9)
            {
                ((ViewModel)DataContext).Result += "9";
            }

            if (e.Key == Key.NumPad0)
            {
                ((ViewModel)DataContext).Result += "0";
            }

            if (e.Key == Key.Divide)
            {
                ((ViewModel)DataContext).Result += "/";
            }

            if (e.Key == Key.Add)
            {
                ((ViewModel)DataContext).Result += "+";
            }

            if (e.Key == Key.Subtract)
            {
                ((ViewModel)DataContext).Result += "-";
            }

            if (e.Key == Key.Multiply)
            {
                ((ViewModel)DataContext).Result += "*";
            }

            if (e.Key == Key.Back)
            {
                string chaine = ((ViewModel)DataContext).Result;
                if (chaine == ERROR)
                {
                    ((ViewModel)DataContext).Result = "";
                }
                else if (chaine != "")
                {
                    ((ViewModel)DataContext).Result = chaine.Remove(chaine.Length - 1);
                } 
            }

            if (e.Key == Key.Escape)
            {
                ((ViewModel)DataContext).Result = "";
            }

            if (e.Key == Key.D5)
            {
                ((ViewModel)DataContext).Result += "(";
            }

            if (e.Key == Key.OemOpenBrackets)
            {
                ((ViewModel)DataContext).Result += ")";
            }

            if (e.Key == Key.Decimal)
            {
                ((ViewModel)DataContext).Result += ",";
            }

            if (e.Key == Key.Enter)
            {
                Result();
            }
        }

        private void Click_0(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "0";
        }

        private void Click_1(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "1";
        }

        private void Click_2(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "2";
        }

        private void Click_3(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "3";
        }

        private void Click_4(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "4";
        }

        private void Click_5(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "5";
        }

        private void Click_6(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "6";
        }

        private void Click_7(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "7";
        }

        private void Click_8(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "8";
        }

        private void Click_9(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "9";
        }
        private void Click_plus(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "+";
        }
        private void Click_moins(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "-";
        }
        private void Click_multiple(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "*";
        }
        private void Click_divise(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "/";
        }
        private void Click_parentheseG(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += "(";
        }
        private void Click_parentheseD(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += ")";
        }
        private void Click_back(object sender, RoutedEventArgs e)
        {
            string chaine = ((ViewModel)DataContext).Result;
            if (chaine == ERROR)
            {
                ((ViewModel)DataContext).Result = "";
            }
            else if (chaine != "")
            {
                ((ViewModel)DataContext).Result = chaine.Remove(chaine.Length - 1);
            }
        }
        private void Click_virgule(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result += ",";
        }
        private void Click_CE(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).Result = "";
        }
<<<<<<< HEAD


=======
>>>>>>> ce335a6c86f2de2e06b16bb59100e2d317bebe97
        private String strFormatter(String s)
        {
            String newS = s.Replace(" ", "");
            char c;
            for (int i = 0; i < newS.Length; i++)
            {
                c = newS[i];
                if (c == '+' || c == '*' || c == '/')
                {
                    newS = newS.Insert(i, " ");
                    newS = newS.Insert(i + 2, " ");
                    i += 2;
                }
                else if (c == '-')
                {
                    if (i != 0 && i != (newS.Length - 1))
                    {
                        if ((System.Char.IsDigit(newS[i + 1]) || newS[i + 1] == '(') && (System.Char.IsDigit(newS[i - 1]) || newS[i - 1] == ')'))
                        {
                            newS = newS.Insert(i, " ");
                            newS = newS.Insert(i + 2, " ");
                            i += 2;
                        }
                    }
                }
                else if (c == '(')
                {
                    newS = newS.Insert(i + 1, " ");
                    i += 1;
                }
                else if (c == ')')
                {
                    newS = newS.Insert(i, " ");
                    i += 1;
                }
            }
            return newS;
        }

<<<<<<< HEAD


=======
>>>>>>> ce335a6c86f2de2e06b16bb59100e2d317bebe97
        void Result()
        {
            String input = strFormatter(((ViewModel)DataContext).Result);
            String stockOperation = ((ViewModel)DataContext).Result.Replace(" ", "");
            bool error = false;
            if (stockOperation == "")
            {
                error = true;
                ((ViewModel)DataContext).Result = ERROR;
            }
            TokenStack operatorStack = new TokenStack();
            TokenStack valueStack = new TokenStack();


            // The tokens that make up the input
            String[] parts = input.Split(' ');
            Token[] tokens = new Token[parts.Length];
            for (int n = 0; n < parts.Length; n++)
            {
                tokens[n] = new Token(parts[n]);
            }

            // Main loop - process all input tokens
            for (int n = 0; n < tokens.Length; n++)
            {
                Token nextToken = tokens[n];
                if (nextToken.getType() == Token.NUMBER)
                {
                    valueStack.push(nextToken);
                }
                else if (nextToken.getType() == Token.OPERATOR)
                {
                    if (operatorStack.isEmpty() || nextToken.getPrecedence() > operatorStack.top().getPrecedence())
                    {
                        operatorStack.push(nextToken);
                    }
                    else
                    {
                        while (!operatorStack.isEmpty() && nextToken.getPrecedence() <= operatorStack.top().getPrecedence())
                        {
                            Token toProcess = operatorStack.top();
                            operatorStack.pop();
                            processOperator(toProcess, valueStack, ref error);
                        }
                        operatorStack.push(nextToken);
                    }
                }
                else if (nextToken.getType() == Token.LEFT_PARENTHESIS)
                {
                    operatorStack.push(nextToken);
                }
                else if (nextToken.getType() == Token.RIGHT_PARENTHESIS)
                {
                    while (!operatorStack.isEmpty() && operatorStack.top().getType() == Token.OPERATOR)
                    {
                        Token toProcess = operatorStack.top();
                        operatorStack.pop();
                        processOperator(toProcess, valueStack, ref error);
                    }
                    if (!operatorStack.isEmpty() && operatorStack.top().getType() == Token.LEFT_PARENTHESIS)
                    {
                        operatorStack.pop();
                    }
                    else
                    {
                        error = true;
                        ((ViewModel)DataContext).Result = ERROR;
                    }
                }

            }
            // Empty out the operator stack at the end of the input
            while (!operatorStack.isEmpty() && operatorStack.top().getType() == Token.OPERATOR)
            {
                Token toProcess = operatorStack.top();
                operatorStack.pop();
                processOperator(toProcess, valueStack, ref error);
            }
            // Print the result if no error has been seen.
            if (error == false)
            {
                Token result = null;
                if (valueStack.getTokens().Count != 0)
                {
                    result = valueStack.top();
                    valueStack.pop();
                }
                if (!operatorStack.isEmpty() || !valueStack.isEmpty() || result == null)
                {
                    ((ViewModel)DataContext).Result = ERROR;
                }
                else
                {
                    ((ViewModel)DataContext).Result = Convert.ToString(result.getValue());
                }
            }
            if (((ViewModel)DataContext).Result != ERROR)
            {
                ((ViewModel)DataContext).AddItem(stockOperation);
                ((ViewModel)DataContext).Calcul = stockOperation;
                ((ViewModel)DataContext).ResultatCalcul = ((ViewModel)DataContext).Result;
            }
        }
        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            Result();
        }

        private void processOperator(Token t, TokenStack valueStack, ref bool error)
        {
            Token A = null, B = null;
            if (valueStack.isEmpty())
            {
                ((ViewModel)DataContext).Result = ERROR;
                error = true;
            }
            else
            {
                B = valueStack.top();
                valueStack.pop();
            }
            if (valueStack.isEmpty())
            {
                ((ViewModel)DataContext).Result = ERROR;
                error = true;
            }
            else
            {
                A = valueStack.top();
                valueStack.pop();
            }
            Token R = null;
            if (A != null && B != null)
            {
                R = t.operate(A.getValue(), B.getValue());
                valueStack.push(R);
            }
            else
            {
                error = true;
            }
        }
        private void Button_Click_Clear_History(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).MaListe.Clear();
        }
    }
}

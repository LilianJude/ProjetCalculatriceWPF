using System;
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

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
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
            if (chaine != "")
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

        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            String input = ((ViewModel)DataContext).Result;
            String stockOperation = input;
            TokenStack operatorStack = new TokenStack();
            TokenStack valueStack = new TokenStack();
            bool error = false;

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
                        ((ViewModel)DataContext).Result = "error";
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
                Token result = valueStack.top();
                valueStack.pop();
                if (!operatorStack.isEmpty() || !valueStack.isEmpty())
                {
                    ((ViewModel)DataContext).Result = "error";
                }
                else
                {
                    ((ViewModel)DataContext).Result = Convert.ToString(result.getValue());
                }
            }
        ((ViewModel)DataContext).AddItem(stockOperation);
        }
        private void processOperator(Token t, TokenStack valueStack, ref bool error)
        {
            Token A = null, B = null;
            if (valueStack.isEmpty())
            {
                ((ViewModel)DataContext).Result = "error";
                error = true;
            }
            else
            {
                B = valueStack.top();
                valueStack.pop();
            }
            if (valueStack.isEmpty())
            {
                ((ViewModel)DataContext).Result = "error";
                error = true;
            }
            else
            {
                A = valueStack.top();
                valueStack.pop();
            }
            Token R = t.operate(A.getValue(), B.getValue());
            valueStack.push(R);
        }
        private void Button_Click_Clear_History(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).MaListe.Clear();
        }
    }
}

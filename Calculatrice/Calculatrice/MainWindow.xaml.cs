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

        public event PropertyChangedEventHandler PropertyChanged;

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
            ((ViewModel)DataContext).AddItem();
        }

        private void Button_Click_Clear_History(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).MaListe.Clear();
        }
    }
}

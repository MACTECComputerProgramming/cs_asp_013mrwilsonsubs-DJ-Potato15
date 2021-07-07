using System;
using System.Collections.Generic;
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

namespace Subway
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            if (sub6.IsChecked==true)
            {
                total += 3.5;
            }
            if(subft.IsChecked == true)
            {
                total += 5;
            }
            if(b3.IsChecked == true)
            {
                total += .50;
            }
            if(m3.IsChecked == true)
            {
                total += 1.00;
            }
            if(m4.IsChecked == true)
            {
                total += 1.50;
            }
            if(c1.IsChecked == true)
            {
                total += .25;
            }
            if(c2.IsChecked == true)
            {
                total += .30;
            }
            if(c3.IsChecked == true)
            {
                total += .75;
            }
            if(v2.IsChecked == true)
            {
                total += .25;
            }
            if(v3.IsChecked == true)
            {
                total += .15;
            }
            if(v4.IsChecked == true)
            {
                total += .10;
            }
            if(v5.IsChecked == true)
            {
                total += .50;
            }
            lbl.Content = total;
        }
    }
}

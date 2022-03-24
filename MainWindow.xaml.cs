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

using System.Text.RegularExpressions;   //  A regex névtere
using ValidationRegEx.utilities;

namespace ValidationRegEx
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


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
            // "[^0-9]+" : Szám "[^a-z]+" : Az angol ABC kisbetűi "[^A-Z]+" : Az angol ABC nagybetűi "[^A-z]+" : Az angol ABC kis és nagybetűi
        }
        private void number_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            nummber_label.Background = ((TextBox)sender).Text.IsValid(For.Int) ? Brushes.Green : Brushes.Red;
        }

        private void phone_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            phone_label.Background = ((TextBox)sender).Text.IsValid(For.Phone) ? Brushes.Green : Brushes.Red;
        }

        private void email_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            email_label.Background = ((TextBox)sender).Text.IsValid(For.Email) ? Brushes.Green : Brushes.Red;
        }
    }
}

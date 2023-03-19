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

namespace Cosmic_farmer
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PageLoaded(object sender, RoutedEventArgs e)
        {
            chrBtn.Items.Add("Характеристики корабля");
            chrBtn.Items.Add("Характеристики автоклава");
            chrBtn.SelectedIndex = 0;
            chrBtn.SelectionChanged += Button_Click;
        }

        private void Button_Click(object sender, SelectionChangedEventArgs e)
        {
            if (chrBtn.SelectedItem.ToString() == "Характеристики автоклава")
            {
                shipDg.Visibility = Visibility.Hidden;
                autoDg.Visibility = Visibility.Visible;
            }
            else
            {
                shipDg.Visibility = Visibility.Visible;
                autoDg.Visibility = Visibility.Hidden;
            }
        }
    }
}

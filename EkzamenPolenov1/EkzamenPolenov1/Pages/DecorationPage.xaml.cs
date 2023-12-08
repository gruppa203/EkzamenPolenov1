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
using EkzamenPolenov1.ApplicationData;

namespace EkzamenPolenov1.Pages
{
    /// <summary>
    /// Логика взаимодействия для DecorationPage.xaml
    /// </summary>
    public partial class DecorationPage : Page
    {
        public DecorationPage()
        {
            InitializeComponent();
            DGridDecor.ItemsSource = BDPolenovEntities1.GetContext().TovarDecoration.ToList();
        }


        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.Navigate(new PageLogin());
        }

        private void DGridDecor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

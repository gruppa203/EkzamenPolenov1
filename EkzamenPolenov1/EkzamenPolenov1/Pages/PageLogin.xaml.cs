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
using EkzamenPolenov1.Pages;

namespace EkzamenPolenov1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnToComeIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = BDPolenovEntities1.GetContext().Users.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == psbPass.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Пользователь с таким логином или паролем не найден", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.Role)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте Клиент " + userObj.Имя__отчество + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppFrame.MainFrame.Navigate(new DecorationPage());
                            break;
                        case 2:
                            MessageBox.Show("Здравствуйте Администратор " + userObj.Имя__отчество + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppFrame.MainFrame.Navigate(new DecorationPage());
                            break;
                        case 3:
                            MessageBox.Show("Здравствуйте Менеджер " + userObj.Имя__отчество + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppFrame.MainFrame.Navigate(new DecorationPage());
                            break;

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка: " + Ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

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

namespace BellMagazine.Pages
{
    /// <summary>
    /// Логика взаимодействия для Navigation.xaml
    /// </summary>
    public partial class Navigation : Page
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void BauAutorization_Click(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text is null)
            {
                MessageBox.Show("Enter Login");
                return;
            }
            if (TbPassword.Password is null)
            {
                MessageBox.Show("Enter Password");
                return;
            }
            Model.Clients client = MainWindow.db.Clients.ToList().FirstOrDefault(c => c.Login == TbLogin.Text && c.Password == TbPassword.Password);
            if (client is null)
            {
                MessageBox.Show("Unknown user");
                return;
            }
            MainWindow.loggeduser = client;
            NavigationService.Navigate(new Pages.PhonePage());
        }
    }
}

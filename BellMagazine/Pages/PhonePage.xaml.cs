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
    /// Логика взаимодействия для PhonePage.xaml
    /// </summary>
    public partial class PhonePage : Page
    {
        public PhonePage()
        {
            InitializeComponent();
            List<Model.Phones> phones = MainWindow.db.Phones.ToList();
            DGPhone.ItemsSource = phones.Where(c=> c != null).ToList();
        }

        private void Page_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}

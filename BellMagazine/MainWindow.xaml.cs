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

namespace BellMagazine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Model.web17Entities1 db = new Model.web17Entities1 ();
        public static Model.Clients loggeduser; 
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.Navigation()); 
            
        }
    }
}

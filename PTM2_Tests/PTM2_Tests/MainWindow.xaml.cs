using PTM2_Tests.Model;
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

namespace PTM2_Tests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Servers sl;
        public MainWindow()
        {
            InitializeComponent();
           sl = new Servers();
        }

        private void addServer_Click(object sender, RoutedEventArgs e)
        {
            Server s3 = new Server();
            s3.Name = "Server3";
            s3.Price = 300;

            sl.ADDServer(s3);
            Servers temp = (Servers)Tab22.DataContext;

        }
    }
}

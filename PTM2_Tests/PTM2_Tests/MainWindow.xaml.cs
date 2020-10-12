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
            sl = (Servers)Tab22.DataContext;
            Server s1 = new Server();
            s1.Name = "Server1";
            s1.Price = 100;
            sl.Servers_list.Add(s1);
            Server s2 = new Server();
            s2.Name = "Server2";
            s2.Price = 200;
            sl.Servers_list.Add(s2);
        }

        private void addServer_Click(object sender, RoutedEventArgs e)
        {
            Server s3 = new Server();
            s3.Name = "Server3";
            s3.Price = 300;

            sl.ADDServer(s3);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PTM2_Tests.Model
{
    public class Servers : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<Server> servers_list;

        internal ObservableCollection<Server> Servers_list { get => servers_list;
            set { servers_list = value;
                OnPropertyChanged(nameof(Servers_list));
            } }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void ADDServer(Server item)
        {
            List<Server> t = new List<Server>();
            t.AddRange(Servers_list);
            t.Add(item);
            Servers_list= new ObservableCollection<Server>(t);
        }



        public Servers()
        {
            Servers_list = new ObservableCollection<Server>();
            Servers_list.CollectionChanged += SL_CollectionChanged;
            Server s1 = new Server();
            s1.Name = "Server1";
            s1.Price = 100;
            Servers_list.Add(s1);
            Server s2 = new Server();
            s2.Name = "Server2";
            s2.Price = 200;
            Servers_list.Add(s2);
        }

        private void SL_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Servers_list));
        }
    }
}

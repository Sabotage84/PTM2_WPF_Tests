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

        static ObservableCollection<Server> servers_list;

        public ObservableCollection<Server> Servers_list { get => servers_list;
            set { servers_list = value;
                OnPropertyChanged(nameof(Servers_list));
            } }

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void ADDServer(Server item)
        {
            
            Servers_list.Add(item);
        }



        public Servers()
        {
            Servers_list = new ObservableCollection<Server>();
            Servers_list.CollectionChanged += SL_CollectionChanged;
           
        }

        private void SL_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Servers_list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Viewmodel
{
    class BaseViewModel : INotifyPropertyChanged, INotifyCollectionChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}

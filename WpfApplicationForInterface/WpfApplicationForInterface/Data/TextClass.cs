using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace WpfApplicationForInterface.Data
{
    public class EnicryptionText : INotifyPropertyChanged
    {
        private string textMsg;
        private string hash;
        public string TextMsg { get { return textMsg; }
            set {
                textMsg = value;
                OnPropertyChanged("TextMsg");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public string Hash
        {
            get
            {
                return hash;
            }
            set
            {
                hash = value;
                OnPropertyChanged("Hash");
            }
        }
    }
}

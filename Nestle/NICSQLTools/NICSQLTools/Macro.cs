using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NICSQLTools
{
    [Serializable()]
    public class Macro : INotifyPropertyChanged
    {
        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public Macro()
        {
            DatabaseFilePath = string.Empty;
            Queries = new BindingList<string>();
        }
        private string _DatabaseFilePath;
        public string DatabaseFilePath
        {
            get
            {
                return _DatabaseFilePath;
            }
            set 
            {
                _DatabaseFilePath = value;
                NotifyPropertyChanged("DatabaseFilePath");
            }
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public BindingList<string> Queries { get; set; }

    }
}

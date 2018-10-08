using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingColor
{
    [Serializable]
    class DataClass : INotifyPropertyChanged
    {
        private String text;
        public String Text
        {
            get { return text; }
            set {
                OnChange("Text");
                text = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnChange(String propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}

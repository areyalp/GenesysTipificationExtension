using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Genesyslab.Desktop.Modules.TipificationExtension.ComboTipification
{
    public class ComboTipificationModel : IComboTipificationViewModel, INotifyPropertyChanged
    {

        List<String> products = new List<string>();
        List<String> tipifications = new List<string>();

        public ComboTipificationModel()
        {
            
        }

        public List<string> Products
        {
            get
            { return products; }

            set
            { if (products != value) { products = value; OnPropertyChanged("Products"); } }
        }

        public List<string> Tipifications
        {
            get
            { return tipifications; }

            set
            { if (tipifications != value) { tipifications = value; OnPropertyChanged("Tipifications"); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

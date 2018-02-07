using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class ViewModel : BaseNotifyPropertyChanged
    {

        public string Result
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }

        public ObservableCollection<string> MaListe
        {
            get { return GetProperty<ObservableCollection<string>>(); }
            set { SetProperty(value); }
        }

        public string MonItemSelectionne
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }

        public ViewModel()
        {
            Result = "";
            MaListe = new ObservableCollection<string>();
        }

        private int cpt = 0;
        public void AddItem()
        {
            cpt++;
            MaListe.Add(Result);
        }
    }
}

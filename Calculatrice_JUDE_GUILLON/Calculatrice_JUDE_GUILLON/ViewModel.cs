using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice_JUDE_GUILLON
{
    public class ViewModel : BaseNotifyPropertyChanged
    {

        public string Result
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }


        public ObservableCollection<Calcul> MaListe
        {
            get { return GetProperty<ObservableCollection<Calcul>>(); }
            set { SetProperty(value); }
        }

        public string MonItemSelectionne
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }

        public string Calcul
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }

        public string ResultatCalcul
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }
        public ViewModel()
        {
            Result = "";
            MaListe = new ObservableCollection<Calcul>();
        }

        private int cpt = 0;
        public void AddItem(string str)
        {
            cpt++;
            MaListe.Add(new Calcul(str, Result));
            ResultatCalcul = Result;
            Calcul = str;
        }
    }
}

using System.ComponentModel;

namespace AlbatrosArayuz
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _takimNo;
        public string TakimNo
        {
            get => _takimNo;
            set { _takimNo = value; OnPropertyChanged("TakimNo"); }
        }

        private string _irtifa;
        public string Irtifa
        {
            get => _irtifa;
            set { _irtifa = value; OnPropertyChanged("Irtifa"); }
        }

        private string _yonelme;
        public string Yonelme
        {
            get => _yonelme;
            set { _yonelme = value; OnPropertyChanged("Yonelme"); }
        }

        private string _dikilme;
        public string Dikilme
        {
            get => _dikilme;
            set { _dikilme = value; OnPropertyChanged("Dikilme"); }
        }

        private string _yatis;
        public string Yatis
        {
            get => _yatis;
            set { _yatis = value; OnPropertyChanged("Yatis"); }
        }

        private string _wifiBaglantisi;
        public string WifiBaglantisi
        {
            get => _wifiBaglantisi;
            set { _wifiBaglantisi = value; OnPropertyChanged("WifiBaglantisi"); }
        }

        private string _sunucuBaglantisi;
        public string SunucuBaglantisi
        {
            get => _sunucuBaglantisi;
            set { _sunucuBaglantisi = value; OnPropertyChanged("SunucuBaglantisi"); }
        }

        private string _sistemSaati;
        public string SistemSaati
        {
            get => _sistemSaati;
            set { _sistemSaati = value; OnPropertyChanged("SistemSaati"); }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

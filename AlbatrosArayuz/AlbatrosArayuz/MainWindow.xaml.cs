using System;
using System.Windows;

namespace AlbatrosArayuz
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ViewModel'i oluşturup DataContext'e bağla
            MainViewModel viewModel = new MainViewModel
            {
                TakimNo = "99",
                Irtifa = "12",
                Yonelme = "33",
                Dikilme = "5",
                Yatis = "15",
                WifiBaglantisi = "1.111..1.111",
                SunucuBaglantisi = "1.111..1.111",
                SistemSaati = DateTime.Now.ToShortTimeString()
            };

            this.DataContext = viewModel;
        }
    }
}

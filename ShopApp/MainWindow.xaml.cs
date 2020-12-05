using ShopLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Shop shop = new Shop();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OdswiezKlientow()
        {
            listBoxKlienci.Items.Clear();
            foreach (Client client in shop.Clients)
            {
                listBoxKlienci.Items.Add(client);
            }
        }

        private void buttonOdswiez_Click(object sender, RoutedEventArgs e)
        {
            OdswiezKlientow();
        }

        private void buttonRejestruj_Click(object sender, RoutedEventArgs e)
        {
            string firstName = textBoxImie.Text;
            string lastName = textBoXNazwisko.Text;
            string address = textBoXAdres.Text;
            shop.RegisterClient(firstName, lastName, address);
            OdswiezKlientow();
        }

        private void buttonUsuńKlienta_Click(object sender, RoutedEventArgs e)
        {
            //object obj = listBoxKlienci.SelectedItem;
            //Client client = (Client)obj;   
            // but what if I have not any client in these objects?


            if (listBoxKlienci.SelectedItem is Client client)
            {
                shop.RemoveClient(client);
                OdswiezKlientow();
            }
            else
                MessageBox.Show("Nie można wykonać operacji", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

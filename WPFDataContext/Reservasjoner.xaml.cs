using System;
using System.Collections.ObjectModel;
using System.Windows;
using WPFDataContext.YourOutputDirectory;

namespace YourNamespace
{
    public partial class Reservasjoner : Window
    {
        private readonly MyFirstDatabaseContext dx = new();
        private readonly ObservableCollection<HotelReservation> hotelReservations = new ObservableCollection<HotelReservation>();

        public Reservasjoner()
        {
            InitializeComponent();

            start_dato_selector.SelectedDate = DateTime.Today;
            slutt_dato_selector.SelectedDate = DateTime.Today.AddYears(1);

            // Load hotel reservations from the database and add them to the collection
            foreach (var reservation in dx.HotelReservations)
            {
                hotelReservations.Add(reservation);
            }

            // Set the collection as the ItemsSource for the ListView
            reservasjonsliste_liste.ItemsSource = hotelReservations;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

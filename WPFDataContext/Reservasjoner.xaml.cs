using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WPFDataContext.YourOutputDirectory;

namespace YourNamespace
{
    public partial class Reservasjoner : Window
    {
        private MyFirstDatabaseContext dx = new();
        private ObservableCollection<HotelReservation> hotelReservations = new ObservableCollection<HotelReservation>();
        private ObservableCollection<HotelRoom> hotelRooms = new ObservableCollection<HotelRoom>();
        public Reservasjoner()
        {
            InitializeComponent();

            start_dato_selector.SelectedDate = DateTime.Today;

            foreach (var reservation in dx.HotelReservations)
            {
                hotelReservations.Add(reservation);
            }

            checkBoxUpdate();

            reservasjonsliste_liste.ItemsSource = hotelReservations;

            reservasjonsliste_liste.SelectionChanged += Reservasjonsliste_liste_SelectionChanged;

            FilterReservations();
        }

        public void checkBoxUpdate()
        {
            hotelRooms.Clear();

            foreach (var room in dx.HotelRooms)
            {
                foreach(var reservasjon in hotelReservations)
                {
                    if(!room.sjekk((DateTime)reservasjon.StartDate, (DateTime)reservasjon.EndDate))
                    {
                        hotelRooms.Add(room);
                    }
                }
                    
                
            }
            dx.SaveChanges();

            roomComboBox.ItemsSource = hotelRooms;
            roomComboBox.DisplayMemberPath = "RoomId";
        }
        private void Reservasjonsliste_liste_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            reservasjon.Items.Clear();

            if (reservasjonsliste_liste.SelectedItem != null)
            {
                HotelReservation selectedReservation = (HotelReservation)reservasjonsliste_liste.SelectedItem;

                reservasjon.Items.Add(selectedReservation);
            }
        }

        private void FilterReservations()
        {
            DateTime startDate = start_dato_selector.SelectedDate ?? DateTime.MinValue;

            var filteredReservations = dx.HotelReservations.Where(r => r.StartDate >= startDate.Date);

            hotelReservations.Clear();
            foreach (var reservation in filteredReservations)
            {
                hotelReservations.Add(reservation);
            }
        }
        private void Reservasjon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            reservasjon.Items.Clear();

            if (reservasjon.SelectedItem != null)
            {
                HotelReservation selectedReservation = (HotelReservation)reservasjon.SelectedItem;
                reservasjon.Items.Add(selectedReservation);
            }

            reservasjon.Items.Refresh();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void update_button_Click(object sender, RoutedEventArgs e)
        {
            if (reservasjon.SelectedItem != null && roomComboBox.SelectedItem != null)
            {
                HotelReservation selectedReservation = (HotelReservation)reservasjon.SelectedItem;
                HotelRoom selectedRoom = (HotelRoom)roomComboBox.SelectedItem;

                if (selectedReservation != null && selectedRoom != null)
                {
                    if (selectedReservation.RoomId != selectedRoom.RoomId)
                    {
                        HotelRoom previousRoom = hotelRooms.FirstOrDefault(r => r.RoomId == selectedReservation.RoomId);

                        selectedReservation.RoomId = selectedRoom.RoomId;

                        dx.HotelReservations.Update(selectedReservation);
                        dx.SaveChanges();

                        FilterReservations();
                        checkBoxUpdate();
                        reservasjon.Items.Clear();
                        reservasjon.Items.Add(selectedReservation);

                    }
                    else
                    {
                        MessageBox.Show("The selected room is already assigned to this reservation.");
                    }
                }
            }
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            if (reservasjon.SelectedItem != null)
            {
                HotelReservation selectedReservation = (HotelReservation)reservasjon.SelectedItem;
                HotelRoom hotelRoom = hotelRooms.FirstOrDefault(r => r.RoomId == selectedReservation.RoomId);

                dx.HotelReservations.Remove(selectedReservation);

                dx.SaveChanges();

                FilterReservations();
                checkBoxUpdate();
            }
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            FilterReservations();
        }
    }
}

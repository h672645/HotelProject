using System.Collections.ObjectModel;
using System.Windows;
using WPFDataContext.YourOutputDirectory;

namespace YourNamespace
{
    public partial class Rom : Window
    {
        private MyFirstDatabaseContext dx = new();
        private ObservableCollection<HotelReservation> hotelReservations = new ObservableCollection<HotelReservation>();
        private ObservableCollection<HotelRoom> hotelRooms = new ObservableCollection<HotelRoom>();
        public Rom()
        {
            InitializeComponent();

            foreach(var hotelroom in dx.HotelRooms)
            {
                hotelRooms.Add(hotelroom);
                romvelger_listebox.Items.Add(hotelroom.RoomId);
            }

            foreach(var hotelreservasjon in dx.HotelReservations)
            {
                hotelReservations.Add(hotelreservasjon);
            }

            romvelger_listebox.SelectionChanged += Romvelger_listbox_SelectionChanged;
        }

        private void Romvelger_listbox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (romvelger_listebox.SelectedItem != null)
            {
                int selectedRoomId = (int)romvelger_listebox.SelectedItem; 
                HotelRoom valgtHotellrom = hotelRooms.FirstOrDefault(r => r.RoomId == selectedRoomId);
                tidsrom_liste.Items.Clear();
                tidsrom_liste2.Items.Clear();
                reservasjonsliste_liste.Items.Clear();

                if (valgtHotellrom != null)
                {
                    foreach (var hotellreservasjon in hotelReservations)
                    {
                        if (hotellreservasjon.RoomId == valgtHotellrom.RoomId)
                        {
                            reservasjonsliste_liste.Items.Add(hotellreservasjon);
                            tidsrom_liste.Items.Add(hotellreservasjon.StartDate);
                            tidsrom_liste2.Items.Add(hotellreservasjon.EndDate);
                            valgtHotellrom.sjekk((DateTime)hotellreservasjon.StartDate, (DateTime)hotellreservasjon.EndDate);
                        }
                    }

                    rom_liste.Items.Clear();
                    status_liste.Items.Clear();
                    rom_liste.Items.Add(valgtHotellrom.ToString()); 
                    status_liste.Items.Add(valgtHotellrom.sjekk());
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

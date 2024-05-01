using System;
using System.Windows;

namespace YourNamespace
{
    public partial class Startside : Window
    {
        private Reservasjoner reservasjonerForm;
        private Rom romForm;
        private NyReservasjon nyReservasjonForm;

        public Startside()
        {
            InitializeComponent();

            // Initialize forms
            reservasjonerForm = new Reservasjoner();
            romForm = new Rom();
            nyReservasjonForm = new NyReservasjon();
            reservasjonerForm.Closed += (s, args) => Show();
            romForm.Closed += (s, args) => Show();
            nyReservasjonForm.Closed += (s, args) => Show();
        }

        private void ShowNyReservationForm()
        {
            nyReservasjonForm = new NyReservasjon();
            nyReservasjonForm.Closed += (s, args) => Show();
            Hide();
            nyReservasjonForm.Show();
        }

        private void ShowReservasjonerForm()
        {
            reservasjonerForm = new Reservasjoner();
            reservasjonerForm.Closed += (s, args) => Show();
            Hide();
            reservasjonerForm.Show();
        }

        private void ShowRoomForm()
        {
            romForm = new Rom();
            romForm.Closed += (s, args) => Show();
            Hide();
            romForm.Show();
        }

        private void reservation_button_Click(object sender, RoutedEventArgs e)
        {
            ShowReservasjonerForm();
        }

        private void room_button_Click(object sender, RoutedEventArgs e)
        {
            ShowRoomForm();
        }

        private void nyReservation_button_Click(object sender, RoutedEventArgs e)
        {
            ShowNyReservationForm();
        }
    }
}

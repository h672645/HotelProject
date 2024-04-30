using System;
using System.Windows.Forms;

namespace HotelComputer
{
    public partial class Startside : Form
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
            reservasjonerForm.FormClosed += (s, args) => Show();
            romForm.FormClosed += (s, args) => Show();
            nyReservasjonForm.FormClosed += (s, args) => Show();
        }

        private void ShowNyReservationForm()
        {
            if(nyReservasjonForm == null || nyReservasjonForm.IsDisposed)
            {
                nyReservasjonForm = new NyReservasjon();
                nyReservasjonForm.FormClosed += (s, args) => Show();
            }
            Hide();
            nyReservasjonForm.Show();
        }

        private void nyReservation_button_Click(object sender, EventArgs e)
        {
            ShowNyReservationForm();
        }


        private void ShowReservasjonerForm()
        {
            if (reservasjonerForm == null || reservasjonerForm.IsDisposed)
            {
                reservasjonerForm = new Reservasjoner();
                reservasjonerForm.FormClosed += (s, args) => Show();
            }

            // Show the Reservasjoner form
            Hide();
            reservasjonerForm.Show();
        }

        private void ShowRoomForm()
        {
            // Recreate the Room form if it's disposed
            if (romForm == null || romForm.IsDisposed)
            {
                romForm = new Rom();
                romForm.FormClosed += (s, args) => Show();
            }

            // Show the Room form
            Hide(); // Don't forget this line
            romForm.Show();
        }

        private void reservation_button_Click(object sender, EventArgs e)
        {
            ShowReservasjonerForm();
        }

        private void room_button_Click(object sender, EventArgs e)
        {
            ShowRoomForm();
        }

        private void nyReservation_button_Click_1(object sender, EventArgs e)
        {
            ShowNyReservationForm();
        }
    }

}

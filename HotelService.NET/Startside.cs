using System;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

namespace HotelComputer
{
    public partial class Startside : Form
    {
        private Reservasjoner reservasjonerForm;
        private Maintenence romForm;
        private Service nyReservasjonForm;

        public Startside()
        {
            InitializeComponent();

            // Initialize forms
            reservasjonerForm = new Reservasjoner();
            romForm = new Maintenence();
            nyReservasjonForm = new Service();
            reservasjonerForm.FormClosed += (s, args) => Show();
            romForm.FormClosed += (s, args) => Show();
            nyReservasjonForm.FormClosed += (s, args) => Show();
        }

        private void ShowNyReservationForm()
        {
            if (nyReservasjonForm == null || nyReservasjonForm.IsDisposed)
            {
                nyReservasjonForm = new Service();
                nyReservasjonForm.FormClosed += (s, args) => Show();
            }
            Hide();
            nyReservasjonForm.Show();
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
                romForm = new Maintenence();
                romForm.FormClosed += (s, args) => Show();
            }

            // Show the Room form
            Hide(); // Don't forget this line
            romForm.Show();
        }

        private void service_button_Click(object sender, EventArgs e)
        {
            ShowReservasjonerForm();
        }

        private void cleaning_button_Click(object sender, EventArgs e)
        {
            ShowRoomForm();
        }

        private void maintenence_button_Click(object sender, EventArgs e)
        {
            ShowNyReservationForm();
        }
    }

}
using System.Windows;

namespace YourNamespace
{
    public partial class Reservasjoner : Window
    {
        public Reservasjoner()
        {
            InitializeComponent();

            start_dato_selector.SelectedDate = DateTime.Today;
            slutt_dato_selector.SelectedDate = DateTime.Today.AddYears(1);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

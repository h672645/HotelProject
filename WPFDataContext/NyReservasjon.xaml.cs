using System.Windows;

namespace YourNamespace
{
    public partial class NyReservasjon : Window
    {
        public NyReservasjon()
        {
            InitializeComponent();

            start_dato_selector.SelectedDate = DateTime.Today.AddDays(1);
            slutt_dato_selector.SelectedDate = DateTime.Today.AddDays(1).AddYears(1);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

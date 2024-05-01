using System.Windows;

namespace YourNamespace
{
    public partial class Rom : Window
    {
        public Rom()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

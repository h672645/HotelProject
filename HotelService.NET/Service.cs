using HotelClasses.NET.YourOutputDirectory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelComputer
{
    public partial class Service : Form
    {
        private MyFirstDatabaseContext dx = new();
        private ObservableCollection<RoomService> roomServices = new ObservableCollection<RoomService>();

        public Service()
        {
            foreach (var serv in dx.RoomServices)
            {
                roomServices.Add(serv);
            }

            InitializeComponent();

            // Populate ListView with roomService data
            foreach (var serv in roomServices)
            {
                // Create ListViewItem with RoomID and Tjeneste values
                ListViewItem item = new ListViewItem(new[] { serv.RoomId.ToString(), serv.Tjeneste });

                // Add the ListViewItem to the ListView
                listofjobs.Items.Add(item);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
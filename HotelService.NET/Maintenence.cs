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
    public partial class Maintenence : Form
    {
        private MyFirstDatabaseContext dx = new();
        private ObservableCollection<HotelRoom> rooms = new ObservableCollection<HotelRoom>();
        private ObservableCollection<CleaningList> roomsToClean = new ObservableCollection<CleaningList>();
        public Maintenence()
        {
            InitializeComponent();

            foreach (var roomToClean in dx.CleaningLists)
            {
                roomsToClean.Add(roomToClean);

            }

            listofjobs.DataSource = roomsToClean;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
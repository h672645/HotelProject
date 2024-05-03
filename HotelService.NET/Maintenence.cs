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

            // Assuming dx.CleaningLists is your data source
            foreach (var roomToClean in dx.CleaningLists)
            {
                roomsToClean.Add(roomToClean);
            }

            // Bind the ObservableCollection to the DataGridView
            listofjobs.DataSource = roomsToClean;

            // Customize the columns to display checkboxes
            DataGridViewCheckBoxColumn cleanedColumn = new DataGridViewCheckBoxColumn();
            cleanedColumn.HeaderText = "Skal Vaskes";
            cleanedColumn.DataPropertyName = "skalVaskes";
            listofjobs.Columns.Add(cleanedColumn);

            DataGridViewCheckBoxColumn repairColumn = new DataGridViewCheckBoxColumn();
            repairColumn.HeaderText = "Under Vask";
            repairColumn.DataPropertyName = "underVask";
            listofjobs.Columns.Add(repairColumn);

            DataGridViewCheckBoxColumn checkedColumn = new DataGridViewCheckBoxColumn();
            checkedColumn.HeaderText = "Ferdig Vasket";
            checkedColumn.DataPropertyName = "ferdigVasket";
            listofjobs.Columns.Add(checkedColumn);

            // Subscribe to the CellContentClick event to handle checkbox state changes
            listofjobs.CellContentClick += listofjobs_CellContentClick;
        }
        private void listofjobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (listofjobs.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    // Update the corresponding boolean property in the CleaningList object
                    var cleaningList = (CleaningList)listofjobs.Rows[e.RowIndex].DataBoundItem;
                    switch (listofjobs.Columns[e.ColumnIndex].DataPropertyName)
                    {
                        case "ferdigVasket":
                            cleaningList.FerdigVasket = !cleaningList.FerdigVasket;
                            listofjobs.Invalidate();
                            listofjobs.Update();
                            roomsToClean[e.RowIndex].FerdigVasket = !roomsToClean[e.RowIndex].FerdigVasket;
                            break;
                        case "underVask":
                            cleaningList.UnderVask = !cleaningList.UnderVask;
                            listofjobs.Invalidate();
                            listofjobs.Update();
                            break;
                        case "skalVaskes":
                            cleaningList.SkalVaskes = !cleaningList.SkalVaskes;
                            listofjobs.Invalidate();
                            listofjobs.Update();
                            break;
                        default:
                            break;
                    }
                    dx.SaveChanges();
                }
            }
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
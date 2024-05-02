using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelComputer
{
    public partial class NyReservasjon : Form
    {
        public NyReservasjon()
        {
            InitializeComponent();

            start_dato_selector.Value = DateTime.Today.AddDays(1);

            slutt_dato_selector.Value = DateTime.Today.AddDays(1).AddYears(1);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
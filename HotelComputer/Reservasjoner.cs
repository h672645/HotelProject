﻿using System;
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
    public partial class Reservasjoner : Form
    {
        public Reservasjoner()
        {
            InitializeComponent();

            start_dato_selector.Value = DateTime.Today;

            slutt_dato_selector.Value = DateTime.Today.AddYears(1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator UserControl(Reservasjoner v)
        {
            throw new NotImplementedException();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
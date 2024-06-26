﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFDataContext.YourOutputDirectory;

namespace WPFDataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly MyFirstDatabaseContext dx = new();

        private LocalView<Admin> Admins;
        private LocalView<Guest> Guests;
        private LocalView<Employee> Employees;
        private LocalView<HotelReservation> hotelReservations;
        private LocalView<HotelRoom> HotelRooms;

        public MainWindow()
        {
            InitializeComponent();

            Admins = dx.Admins.Local;
            dx.Admins.Load();

            Guests = dx.Guests.Local;
            dx.Guests.Load();

            Employees = dx.Employees.Local;
            dx.Employees.Load();

            hotelReservations = dx.HotelReservations.Local;
            dx.HotelReservations.Load();

            HotelRooms = dx.HotelRooms.Local;
            dx.HotelRooms.Load();

        }
    }
}
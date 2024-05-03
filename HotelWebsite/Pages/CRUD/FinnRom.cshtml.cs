using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelWebsite.NET.YourOutputDirectory;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Identity;
using NuGet.Packaging.Signing;

namespace HotelWebsite.NET.Pages.CRUD
{
    public class FinnRomModel : PageModel
    {
        private static int resId = 10;
        private static int gjestId = 10;
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public FinnRomModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestId");
        ViewData["RoomId"] = new SelectList(_context.HotelRooms, "RoomId", "RoomId");
            return Page();
        }

        public int reservasjonId { get; set; }
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public int guestId { get; set; }
        [BindProperty]
        public HotelReservation HotelReservation { get; set; } = default!;
        [BindProperty]
        public HotelRoom hotelRoom { get; set; } = default!;
        public string errormessage { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                errormessage = "feil i inputen";
                return Page();
            }

            Guest gjesten = new Guest();
            gjesten.GuestId = ++gjestId;
            HotelReservation.GuestId = guestId;
            if(_context.HotelRooms.Any(h => hotelRoom.QualityOfRoom==h.QualityOfRoom && hotelRoom.NumberOfBeds == h.NumberOfBeds && hotelRoom.SizeOfRoom == h.SizeOfRoom && h.Occupied==false)) {
                
                if (_context.HotelRooms.Any(h => h.HotelReservations.Any(r => r.StartDate <= HotelReservation.StartDate && r.EndDate >= HotelReservation.EndDate)))
                {
                    errormessage = "rommet er optatt i den tiden";
                    return Page();
                }
                else
                {
                    int roomid = _context.HotelRooms.Where(h => hotelRoom.QualityOfRoom == h.QualityOfRoom && hotelRoom.NumberOfBeds == h.NumberOfBeds && hotelRoom.SizeOfRoom == h.SizeOfRoom && h.Occupied == false).ToList().First().RoomId;
                    HotelReservation.RoomId = roomid;
                    HotelReservation.Guest= gjesten;
                    HotelReservation.GuestId = gjesten.GuestId;
                    HotelReservation.ReservationId = ++resId;
                    _context.HotelRooms.Where(h => hotelRoom.QualityOfRoom == h.QualityOfRoom && hotelRoom.NumberOfBeds == h.NumberOfBeds && hotelRoom.SizeOfRoom == h.SizeOfRoom && h.Occupied == false).ToList().First().HotelReservations.Add(HotelReservation);
                    _context.HotelReservations.Add(HotelReservation);
                    await _context.SaveChangesAsync();
                    TempData["RoomId"] = HotelReservation.RoomId;
                    errormessage = "";
                    return RedirectToPage("./BestiltRom");
                }
            }
            errormessage = "fant ikke rom med de kriteriene";
            return Page();

        }
    }
}

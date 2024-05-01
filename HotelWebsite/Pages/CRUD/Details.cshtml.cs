using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelWebsite.NET.YourOutputDirectory;

namespace HotelWebsite.NET.Pages.Reservasjoner
{
    public class DetailsModel : PageModel
    {
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public DetailsModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
        {
            _context = context;
        }

        public HotelReservation HotelReservation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelreservation = await _context.HotelReservations.FirstOrDefaultAsync(m => m.ReservationId == id);
            if (hotelreservation == null)
            {
                return NotFound();
            }
            else
            {
                HotelReservation = hotelreservation;
            }
            return Page();
        }
    }
}

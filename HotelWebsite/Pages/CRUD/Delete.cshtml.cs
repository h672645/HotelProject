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
    public class DeleteModel : PageModel
    {
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public DeleteModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelreservation = await _context.HotelReservations.FindAsync(id);
            if (hotelreservation != null)
            {
                HotelReservation = hotelreservation;
                _context.HotelReservations.Remove(HotelReservation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelWebsite.NET.YourOutputDirectory;

namespace HotelWebsite.NET.Pages.Reservasjoner
{
    public class EditModel : PageModel
    {
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public EditModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
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

            var hotelreservation =  await _context.HotelReservations.FirstOrDefaultAsync(m => m.ReservationId == id);
            if (hotelreservation == null)
            {
                return NotFound();
            }
            HotelReservation = hotelreservation;
           ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestId");
           ViewData["RoomId"] = new SelectList(_context.HotelRooms, "RoomId", "RoomId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HotelReservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelReservationExists(HotelReservation.ReservationId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HotelReservationExists(int id)
        {
            return _context.HotelReservations.Any(e => e.ReservationId == id);
        }
    }
}

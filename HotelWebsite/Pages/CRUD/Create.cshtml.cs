using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelWebsite.NET.YourOutputDirectory;

namespace HotelWebsite.NET.Pages.Reservasjoner
{
    public class CreateModel : PageModel
    {
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public CreateModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GuestId"] = new SelectList(_context.Guests, "GuestId", "GuestId");
        ViewData["RoomId"] = new SelectList(_context.HotelRooms, "RoomId", "RoomId");
            return Page();
        }

        [BindProperty]
        public HotelReservation HotelReservation { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HotelReservations.Add(HotelReservation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

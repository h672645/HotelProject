using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelWebsite.NET.YourOutputDirectory;

namespace HotelWebsite.NET.Pages.CRUD
{
    public class BestiltRomModel : PageModel

    {

        public int roomId { get; set; }
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public BestiltRomModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            roomId = (int)TempData["RoomId"];
            return Page();
        }

        [BindProperty]
        public HotelRoom HotelRoom { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HotelRooms.Add(HotelRoom);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

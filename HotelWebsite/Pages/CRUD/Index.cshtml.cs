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
    public class IndexModel : PageModel
    {
        private readonly HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext _context;

        public IndexModel(HotelWebsite.NET.YourOutputDirectory.MyFirstDatabaseContext context)
        {
            _context = context;
        }

        public IList<HotelReservation> HotelReservation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            HotelReservation = await _context.HotelReservations
                .Include(h => h.Guest)
                .Include(h => h.Room).ToListAsync();
        }
    }
}

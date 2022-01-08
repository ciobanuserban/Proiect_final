using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_final.Data;
using Proiect_final.Models;

namespace Proiect_final.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_final.Data.Proiect_finalContext _context;

        public IndexModel(Proiect_final.Data.Proiect_finalContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; }

        public async Task OnGetAsync()
        {
            Song = await _context.Song.Include(b => b.RecordLabel)ToListAsync();
        }
    }
}

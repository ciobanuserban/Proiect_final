using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_final.Data;
using Proiect_final.Models;

namespace Proiect_final.Pages.RecordLabels
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_final.Data.Proiect_finalContext _context;

        public CreateModel(Proiect_final.Data.Proiect_finalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["RecordLabelID"] = new SelectList(_context.Set<RecordLabel>(), "ID", "RecorLabelName");

            return Page();
        }

        [BindProperty]
        public RecordLabel RecordLabel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RecordLabel.Add(RecordLabel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

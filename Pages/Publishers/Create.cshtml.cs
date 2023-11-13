﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Betea_Bianca_LAB2.Data;
using Betea_Bianca_LAB2.Models;

namespace Betea_Bianca_LAB2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Betea_Bianca_LAB2.Data.Betea_Bianca_LAB2Context _context;

        public CreateModel(Betea_Bianca_LAB2.Data.Betea_Bianca_LAB2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

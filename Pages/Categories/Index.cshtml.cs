﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Betea_Bianca_LAB2.Data;
using Betea_Bianca_LAB2.Models;

namespace Betea_Bianca_LAB2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Betea_Bianca_LAB2.Data.Betea_Bianca_LAB2Context _context;

        public IndexModel(Betea_Bianca_LAB2.Data.Betea_Bianca_LAB2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
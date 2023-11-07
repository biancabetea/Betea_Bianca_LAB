using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Betea_Bianca_LAB2.Models;

namespace Betea_Bianca_LAB2.Data
{
    public class Betea_Bianca_LAB2Context : DbContext
    {
        public Betea_Bianca_LAB2Context (DbContextOptions<Betea_Bianca_LAB2Context> options)
            : base(options)
        {
        }

        public DbSet<Betea_Bianca_LAB2.Models.Book> Book { get; set; } = default!;
    }
}

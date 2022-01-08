using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_final.Models;

namespace Proiect_final.Data
{
    public class Proiect_finalContext : DbContext
    {
        public Proiect_finalContext (DbContextOptions<Proiect_finalContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_final.Models.Song> Song { get; set; }

        public DbSet<Proiect_final.Models.RecordLabel> RecordLabel { get; set; }

        public DbSet<Proiect_final.Models.Genre> Genre { get; set; }
    }
}

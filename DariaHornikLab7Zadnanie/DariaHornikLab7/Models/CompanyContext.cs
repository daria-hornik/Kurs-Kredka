using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DariaHornikLab7Zadanie.Models
{
    public class CompanyContext : DbContext
    {
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="options"></param>
        public CompanyContext(DbContextOptions<CompanyContext> options)
           : base(options)
        {
        }

        //połączenie z baza
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Shop> Shop { get; set; }

    }
}

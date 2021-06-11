using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab4Zadanie.Models
{
    class BookstoreContext : DbContext
    {

        public BookstoreContext() : base("Book")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Bookstore> GetBookstores { get; set; }
        public virtual DbSet<Warehouse> Warehauses { get; set; }
    }
    
}

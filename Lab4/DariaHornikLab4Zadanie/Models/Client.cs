using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab4Zadanie.Models
{
    class Client
    {
        [Key]
        public int Id_Client { get; set; }


        [DisplayName("Imie")]
        [StringLength(30)]
        public string name { get; set; }

        [Required]
        [DisplayName("Nazwisko")]
        [StringLength(30)]
        public string surname { get; set; }

        [DisplayName("Data urodzenia")]
        public DateTime birthData { get; set; }

        public virtual Address address { get; set; }

       public virtual ICollection<Book> books { get; set; }

    }
}

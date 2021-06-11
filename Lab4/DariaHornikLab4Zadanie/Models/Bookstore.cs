using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab4Zadanie.Models
{
    class Bookstore
    {
        [Key]
        [DisplayName("ID")]
        public int Id_Bookstore { get; set; }

        [Required]
        [DisplayName("Nazwa księgarni")]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [DisplayName("Adres")]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [DisplayName("Właściciel księgarni")]
        [StringLength(50)]
        public string owner { get; set; }

    }
}

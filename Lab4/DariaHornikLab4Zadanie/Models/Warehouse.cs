using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab4Zadanie.Models
{
    class Warehouse
    {
        [Key]
        [ForeignKey("book")]
        public int Id_Ware { get; set; }

        [DisplayName("Liczba dostępnyc produktów")]   
        public int numberOfItems { get; set; }

        public virtual Book book { get; set; }
    }
}

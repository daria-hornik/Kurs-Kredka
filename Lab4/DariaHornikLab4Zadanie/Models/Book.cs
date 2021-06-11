using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariaHornikLab4Zadanie.Models
{
    class Book
    {
        [Key]
        
        public int Id_Book { get; set; }

        [Required]
        [DisplayName("Tytuł książki")]
        [StringLength(30)]
        public string title { get; set; }

        [Required]
        [DisplayName("Autor")]
        [StringLength(30)]
        public string author { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime releaseData { get; set; }

        [Required]
        [DisplayName("Język")]
        public string language { get; set; }

        public virtual Warehouse warehouse { get; set;  } 

        /// <summary>
        /// Przeciążenie metody, by wyświetlała tytuł
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        {
            return title;
        }
    }
}

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
    class Address
    {
        [Key]
        [ForeignKey("client")]
        public int Id_Address { get; set; }

        [Required]
        [DisplayName("ulica")]
        [StringLength(30)]
        public string street { get; set; }

        [Required]
        public int houseNumber;

        [Required]
        [DisplayName("Kod pocztowy")]
        public int ZipCode { get; set; }

        [Required]
        [DisplayName("Miasto")]
        [StringLength(30)]
        public string city { get; set; }

       
        public virtual Client client{get; set;}
         
        /// <summary>
        /// metoda zwracająca informacje: ulice, numer domu, kod pocztowy i miasto
        /// </summary>
        /// <returns></returns>
        public string GetInformations()
        {
            return street + " " + houseNumber + ", " + ZipCode + " " + city;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm tt}", ApplyFormatInEditMode = true)]
        //toda propiedad DATE debe tener una propiedad de lectura para evitar errores con los horarios de otros países
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        //se crea la propiedad de sólo lectura para la fecha y evitar problemas con las fechas 
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();

        //se crea la propiedad que hace la relación entre agenda y owner
        public Owner Owner { get; set; }

        //se crea la propiedad que hace la relación entre agenda y pet
        public Pet Pet { get; set; }
    }
}

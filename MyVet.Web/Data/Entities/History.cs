using System;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Description")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        //toda propiedad DATE debe tener una propiedad de lectura para evitar errores con los horarios de otros países
        public DateTime Date { get; set; }

        public string Remarks { get; set; }
        //se crea la propiedad de lectura para controlar los horarios de la fecha Date
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

        //se crea la propiedad que va a ser la relación entre history y serviceType
        public ServiceType ServiceType { get; set; }

        //se crea la propiedad que hace la relación entre history y pet
        public Pet Pet { get; set; }
    }
}

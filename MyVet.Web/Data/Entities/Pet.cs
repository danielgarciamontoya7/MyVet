using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Race { get; set; }

        [Display(Name = "Born")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        //se crea una propiedad de sólo lectura para obtener la ruta de la imagen
        //se hace con un OPERADOR TERNARIO para ahorrar código
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TBD.azurewebsites.net{ImageUrl.Substring(1)}";

        //se crea la propiedad de sólo lectura para la propiedad Born, para evitar errores con las fechas
        [Display(Name = "Born")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime BornLocal => Born.ToLocalTime();

        //se crea la propiedad que va a ser la relación entre las entidades pet y pettype
        public PetType PetType { get; set; }

        //se crea la propiedad que va a ser la relación entre las entidades pet y owner
        public Owner Owner { get; set; }

        //se crea la propiedad que hace la relación entre pet y history
        public ICollection<History> Histories { get; set; }

        //se crea la propiedad que hace la relación entre agenda y pet
        public ICollection<Agenda> Agendas { get; set; }
    }
}

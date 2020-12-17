using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        /*
        //se hace la validación con el DataNotation para que no permita documentos nulos
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        //se agrega otro DataNotation para establecer un máximo de caracteres
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Document { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //usamos el DataNotation Display, para mostrar al usuario la propiedad de una forma más llamativa o simplemente como queremos que el usuario la vea
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        //se crea un campo calculado, que se llama PROPIEDAD DE LECTURA, que combinará el nombre y el apellido
        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";
        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
        */

        //se crea la propiedad que copia el modelo User y a su vez trae todos las propiedades de user y del identity user
        public User User { get; set; }
        //se crea la propiedad que va a ser la relación entre pet y owner
        public ICollection<Pet> Pets { get; set; }

        //se crea la propiedad que hace la relación entre agenda y owner
        public ICollection<Agenda> Agendas { get; set; }
    }
}

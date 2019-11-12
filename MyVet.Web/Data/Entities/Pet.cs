using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es Obliatorio")]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Race { get; set; }

        [Display(Name = "Nacimiento")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        //TODO Remplazar por la URL Correcta de la Imagen
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl) ? null
            : $"https://TBD.azurewebsites.net{ImageUrl.Substring(1)}";

        [Display(Name = "Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Born.ToLocalTime();

        public PetType PetType { get; set; }
        public Owner Owner { get; set; }
        public ICollection<History> Histories { get; set; }
        public ICollection<Agenda> Agendas { get; set; }

    }
}

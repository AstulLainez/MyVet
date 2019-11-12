using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyVet.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Mascota")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede ser mayor a {1} caracteres")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        public string Name { get; set; }

        public ICollection<History> Histories { get; set; }
    }
}

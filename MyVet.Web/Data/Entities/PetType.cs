using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class PetType
    {
        public int Id{ get; set; }

        [Display(Name="Tipo de Mascota"]
        [MaxLength (50, ErrorMessage= "El campo {0} no puede ser mayor a {1} caracteres")]
        [Required (ErrorMessage ="El Campo {0} es Obligatorio")]
        public string Name { get; set; }
    }
}

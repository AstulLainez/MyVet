using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage ="El Campo {0} no puede tener mas de {1} Caracteres.")]
        public string Document { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name ="Fixed Phone")]
        public string FixedPhone { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name ="Cell Phone")]
        public string Cellphone { get; set; }

        [MaxLength(100, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        public string Address { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Pet> pets { get; set; }
        public ICollection<Agenda>  Agendas { get; set; }


    }
}

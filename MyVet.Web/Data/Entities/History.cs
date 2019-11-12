using System;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El Campo {0} no puede ser mayor a {1} caracteres")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        public string Description { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

        public ServiceType ServiceType { get; set; }
        public Pet Pet { get; set; }
    }


}


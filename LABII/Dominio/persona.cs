using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LABII.Dominio
{
    public class persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Espacio requerido")]
        public string NombrePersona { get; set; }
        [Display(Name = "Edad")]
        [Range(18,100,ErrorMessage ="Solo se permiten mayores de edad")]
        [Required(ErrorMessage = "Espacio requerido")]
        public int EdadPersona { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Espacio requerido")]
        public string DescripcionPersona { get; set; }

    }
}

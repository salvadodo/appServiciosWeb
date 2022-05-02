using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioWebNegocios
{
    public class Casas
    {
        public int idCasa { get; set; }

        [Required]
        [StringLength(15)]
        public string tipodeCasa { get; set; }

        [Required]
        [StringLength(50)]
        public string Ubicacion { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int? Dueño { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioWebNegocios
{
    public class Dueños
    {
        [Key]
        public int idDueño { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }
    }
}

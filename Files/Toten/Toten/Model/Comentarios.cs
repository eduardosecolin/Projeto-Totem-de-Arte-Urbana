using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toten.Model
{
    public partial class Comentarios
    {

        public int id { get; set; }

        [StringLength(500)]
        public string comentario { get; set; }

        public int id_imagem { get; set; }
    }
}

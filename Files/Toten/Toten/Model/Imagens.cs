namespace Toten.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Imagens
    {
        public int id { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        [StringLength(50)]
        public string cidade { get; set; }

        [StringLength(50)]
        public string regiao { get; set; }

        [StringLength(50)]
        public string descrcao { get; set; }

        public int? like_positivo { get; set; }

        public int? like_negativo { get; set; }
        public int? comentarios { get; set; }

        [Required]
        public byte[] imagem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class TipoHerramienta
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual List<Herramienta> Herramienta { get; set; }
    }
}

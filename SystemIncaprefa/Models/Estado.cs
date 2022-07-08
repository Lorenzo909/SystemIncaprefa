using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Estado
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Herramienta> Herramientas { get; set; }
    }
}

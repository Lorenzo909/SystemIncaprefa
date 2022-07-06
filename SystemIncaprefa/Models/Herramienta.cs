using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Herramienta
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int TipoHerramientaId { get; set; }
        public int EstadoId { get; set; }

        public virtual Estado Estados { get; set; }
        public virtual TipoHerramienta TipoHerramientas { get; set; }
    }
}

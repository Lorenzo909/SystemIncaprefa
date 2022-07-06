using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Material
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public int CategoriaId { get; set; }
        public int UnidadId { get; set; }

        public virtual Categoria Categorias { get; set; }
        public virtual Unidad Unidades { get; set; }
    }
}

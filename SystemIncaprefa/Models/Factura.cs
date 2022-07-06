using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Factura
    {
        [Key]
        public int Id { get; set; }
        public string Consecutivo { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaEmicion { get; set; }
        public int? CuentaId { get; set; }
        public int? ProveedorId { get; set; }

        public virtual Cuenta Cuentas { get; set; }
        public virtual Proveedor Proveedores { get; set; }
    }
}

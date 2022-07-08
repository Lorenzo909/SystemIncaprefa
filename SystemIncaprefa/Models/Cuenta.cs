using ISystemIncaprefa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Cuenta
    {
        [Key]
        public int Id { get; set; }
        public string TipoCuenta { get; set; }

        public virtual List<Factura> Facturas { get; set; }
    }
}

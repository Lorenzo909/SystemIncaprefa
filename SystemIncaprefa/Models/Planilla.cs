using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Planilla
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaPago { get; set; }
        public int? Horas { get; set; }
        public decimal? PrecioHora { get; set; }
        public decimal? Pago { get; set; }
        public int? EmpleadoId { get; set; }
        public int? PuestoId { get; set; }

        public virtual Empleado Empleados { get; set; }
        public virtual Puesto Puestos { get; set; }
    }
}

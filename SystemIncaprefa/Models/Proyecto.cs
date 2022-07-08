﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemIncaprefa.Models
{
    public partial class Proyecto
    {
        [Key]
        public int Id { get; set; }
        public string Contratacion { get; set; }
        public string NombreProyecto { get; set; }
        public decimal MontoProyecto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal GastoMaterial { get; set; }
        public decimal GastoManoObra { get; set; }
        public decimal Utilidad { get; set; }
    }
}

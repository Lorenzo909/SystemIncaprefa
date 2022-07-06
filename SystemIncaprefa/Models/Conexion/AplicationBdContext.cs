using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncaprefaS.A.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SystemIncaprefa.Models.Categoria> Categorias { get; set; }
        public DbSet<SystemIncaprefa.Models.Contacto> Contactos { get; set; }
        public DbSet<SystemIncaprefa.Models.Cuenta> Cuentas { get; set; }
        public DbSet<SystemIncaprefa.Models.Empleado> Empleados { get; set; }
        public DbSet<SystemIncaprefa.Models.Estado> Estados { get; set; }
        public DbSet<SystemIncaprefa.Models.Factura> Facturas { get; set; }
        public DbSet<SystemIncaprefa.Models.Herramienta> Herramientas { get; set; }
        public DbSet<SystemIncaprefa.Models.Material> Materiales { get; set; }
        public DbSet<SystemIncaprefa.Models.Planilla> Planillas { get; set; }
        public DbSet<SystemIncaprefa.Models.Proveedor> Proveedores { get; set; }
        public DbSet<SystemIncaprefa.Models.Proyecto> Proyectos { get; set; }
        public DbSet<SystemIncaprefa.Models.Puesto> Puestos { get; set; }
        public DbSet<SystemIncaprefa.Models.Servicio> Servicios { get; set; }
        public DbSet<SystemIncaprefa.Models.TipoHerramienta> TipoHerramientas { get; set; }
        public DbSet<SystemIncaprefa.Models.Unidad> Unidades { get; set; }
    }
}

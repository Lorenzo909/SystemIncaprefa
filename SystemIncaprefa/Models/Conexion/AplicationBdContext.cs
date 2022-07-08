using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemIncaprefa.Models;

namespace IncaprefaS.A.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Herramienta> Herramientas { get; set; }
        public DbSet<Material> Materiales { get; set; }
        public DbSet<Planilla> Planillas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Puesto> Puestos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoHerramienta> TipoHerramientas { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
    }
}

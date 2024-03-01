#region REFERENCIAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referencias Necesarias Para El Correcto Funcionamiento
using Microsoft.EntityFrameworkCore;
using ASA.SysAdministrativo.EN.Empleados_EN;


#endregion

namespace ASA.SysAdministrativo.DAL
{
    public class ContextDB : DbContext
    {
        #region REFERENCIAS DE TABLAS DE LA BD
        public DbSet<Empleados> Empleados { get; set; } //Coleccion que hace referencia a la tabla de la base de datos
        #endregion

        // Metodo de configuracion a la conexion a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=ASASysAdministrativoDB;Integrated Security=True;Trust Server Certificate=True"); //Poner str de concexion local o remota
        }
    }
}

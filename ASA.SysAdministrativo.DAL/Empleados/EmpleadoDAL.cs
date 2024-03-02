#region REFERENCIAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referencias Necesarias Para El Correcto Funcionamiento
using ASA.SysAdministrativo.EN.Empleados_EN;
using Microsoft.EntityFrameworkCore;


#endregion

namespace ASA.SysAdministrativo.DAL.Empleados
{
    public class EmpleadoDAL
    {
        #region METODO PARA GUARDAR
        // Metodo para guardar un nuevo registro a la base de datos
        public static async Task<int> CrearEmpleadoAsync (Empleado pEmpleados)
        {
            int result = 0;
            // Un bloque de conexion que mientras se permanezca en el bloque la base de datos permanecera abierta y al terminar se destruira
            using (var dbContext = new ContextDB())
            {
                dbContext.Add(pEmpleados);
                result = await dbContext.SaveChangesAsync(); // Await sirve para esperar a terminar todos los procesos para devolverlos todos juntos
            }
            return result;  // Si se realizo con exito devuelve 1 sino devuelve 0
        }
        #endregion

        #region METODO PARA MOSTRAR
        //Metodo para mostrar una lista de Registros
        public static async Task<List<Empleado>> GetAllAsync()
        {
            var empleados = new List<Empleado>();
            using (var dbContext = new ContextDB())
            {
                empleados = await dbContext.Empleados.ToListAsync();
            }
            return empleados;
        }
        #endregion
    }
}

#region REFERENCIAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referencias Necesarias Para El Correcto Funcionamiento
using ASA.SysAdministrativo.DAL.Empleados;
using ASA.SysAdministrativo.EN.Empleados_EN;

#endregion

namespace ASA.SysAdministrativo.BL.Empleados
{
    public class EmpleadosBL
    {
        #region METODO PARA GUARDAR
        // Metodo para guardar un nuevo registro a la base de datos
        public async Task<int> CreateAsync(Empleado employee)
        {
            return await EmpleadoDAL.CrearEmpleadoAsync(employee);
        }
        #endregion
    }
}

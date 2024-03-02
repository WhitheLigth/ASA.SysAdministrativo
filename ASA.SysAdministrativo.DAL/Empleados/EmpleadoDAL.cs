﻿#region REFERENCIAS
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

        #region METODO PARA BUSCAR REGISTROS MEDIANTE EL USO DE FILTROS (Por Id, Por Nombre y por DUI)
        // IQueryable es una interfaz que toma un coleccion a la cual se le pueden implementar multiples consultas (Filtros) 
        internal static IQueryable<Empleado> QuerySelect(IQueryable<Empleado> query, Empleado employee)
        {
            // Por ID
            if (employee.Id > 0)
                query = query.Where(c => c.Id == employee.Id);

            // Por Nomnbre, Si es verdadero lo vuelve falso y viceversa 
            if (!string.IsNullOrWhiteSpace(employee.Nombre))
                query = query.Where(c => c.Nombre.Contains(employee.Nombre));

            // Se agrego por si se llega a utilizar
            if (!string.IsNullOrWhiteSpace(employee.Dui))
                query = query.Where(c => c.Dui.Contains(employee.Dui));

            query = query.OrderByDescending(c => c.Id).AsQueryable();

            // Para la cantidad de registros a mostrar 
            if (employee.Top_Aux > 0)
                query = query.Take(employee.Top_Aux).AsQueryable();

            return query;

        }
        #endregion

        #region METODO PARA BUSCAR
        // Metodo para buscar registros existentes
        public static async Task<List<Empleado>> SearchAsync(Empleado pEmpleado)
        {
            var empleados = new List<Empleado>();
            using (var dbContext = new ContextDB())
            {
                var select = dbContext.Empleados.AsQueryable();
                select = QuerySelect(select, pEmpleado);
                empleados = await select.ToListAsync();
            }
            return empleados;
        }
        #endregion
    }
}

﻿#region REFERENCIAS
using Microsoft.AspNetCore.Http;
// Referencias Necesarias Para El Correcto Funcionamiento
using ASA.SysAdministrativo.EN.Empleados_EN;
using Microsoft.AspNetCore.Mvc;
using ASA.SysAdministrativo.BL.Empleados;


#endregion

namespace ASA.SysAdministrativo.Web.Controllers.Empleados___Controller
{
    public class EmpleadoController : Controller
    {
        // Creamos la Instancia para Acceder a los metodos
        EmpleadosBL empleadosBL = new EmpleadosBL();

        #region METODO PARA MOSTRAR INDEX
        // Metodo para mostrar la vista Index de Empleados
        public async Task<IActionResult> Index(Empleado employee = null)
        {
            if (employee == null)
                employee = new Empleado();
            if (employee.Top_Aux == 0)
                employee.Top_Aux = 10;
            else if (employee.Top_Aux == -1)
                employee.Top_Aux = 0;

            var employees = await empleadosBL.SearchAsync(employee);
            ViewBag.Top = employee.Top_Aux;
            return View(employees);
        }
        #endregion

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        #region METODOS PARA GUARDAR
        // Metodo que muestra la vista para crear una categoria
        public ActionResult Create()
        {
            ViewBag.Error = "";
            return View();
        }

        // Accion que recibe los datos del formulario para ser enviados a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Empleado pEmpleado)
        {
            try
            {
                int result = await empleadosBL.CreateAsync(pEmpleado);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
        #endregion

        #region METODO PARA MODIFICAR
        // Metodo para modificar un registro existente en la base de datos
        public async Task<IActionResult> Edit(int id)
        {
            var empleado = await empleadosBL.GetByIdAsync(new Empleado { Id = id });
            ViewBag.Error = "";
            return View(empleado);
        }

        // Metodo para modificar un registro existente en la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Empleado pEmpleado)
        {
            try
            {
                int result = await empleadosBL.UpdateAsync(pEmpleado);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }
        }

        #endregion

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

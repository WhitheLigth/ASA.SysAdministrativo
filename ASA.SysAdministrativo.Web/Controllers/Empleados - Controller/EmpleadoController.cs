#region REFERENCIAS
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

        // GET: EmpleadoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        #region METODOS PARA GUARDAR
        // Metodo que muestra la vista para crear una categoria
        public ActionResult CreateEmpleadoView()
        {
            ViewBag.Error = "";
            return View();
        }

        // Accion que recibe los datos del formulario para ser enviados a la base de datos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(Empleado pEmpleado)
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

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

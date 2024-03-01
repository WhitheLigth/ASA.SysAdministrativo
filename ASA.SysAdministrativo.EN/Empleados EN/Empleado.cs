#region REFERENCIAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referencias Necesarias Para El Correcto Funcionamiento
using System.ComponentModel.DataAnnotations;

#endregion

namespace ASA.SysAdministrativo.EN.Empleados_EN
{
    public class Empleado
    {
        #region Atributos para Empleados
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")] //Indica que es un campo requerido
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Nombre")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El Nombre debe contener solo Letras")] // Validamos el tipo de dato
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Apellido es requerido")] //Indica que es un campo requerido
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Apellido")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El Apellido debe contener solo Letras")] // Validamos el tipo de dato
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Dui es requerido")] //Indica que es un campo requerido
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Dui")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[0-9-]+$", ErrorMessage = "El Dui debe contener solo números")] // Validamos el tipo de dato
        public string Dui { get; set; } = string.Empty;

        [Required(ErrorMessage = "La Fecha de Nacimiento es requerida")] //Indica que es un campo requerido
        [Display(Name = "Fecha de Nacimiento")] // Una tipo traduccion (esto lo vera el cliente) 
        [DataType(DataType.Date, ErrorMessage = "Por favor, introduce una fecha válida")]
        public DateTime FechaDeNacimiento { get; set; } = DateTime.MinValue;

        [Required(ErrorMessage = "La Edad es requerida")] //Indica que es un campo requerido
        [Display(Name = "Edad")] // Una tipo traduccion (esto lo vera el cliente) 
        public string Edad { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Genero es requerido")] //Indica que es un campo requerido
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Genero")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El Genero debe contener solo Letras")] // Validamos el tipo de dato
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Estado Civil es requerido")] //Indica que es un campo requerido
        [StringLength(15, ErrorMessage = "Maximo 15 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Estado Civil")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El Estado Civil debe contener solo Letras")] // Validamos el tipo de dato
        public string EstadoCivil { get; set; } = string.Empty;

        [Required(ErrorMessage = "La Direccion es requerida")] //Indica que es un campo requerido
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Direccion")] // Una tipo traduccion (esto lo vera el cliente) 
        public string Direccion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Telefono es requerido")] //Indica que es un campo requerido
        [StringLength(9, ErrorMessage = "Maximo 9 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Telefono")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[0-9-]+$", ErrorMessage = "El Telefono debe contener solo números")] // Validamos el tipo de dato
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Correo Electronico es requerido")] //Indica que es un campo requerido
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Correo Electronico")] // Una tipo traduccion (esto lo vera el cliente)
        public string CorreoElectronico { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Numero de Emergencia es requerido")] //Indica que es un campo requerido
        [StringLength(9, ErrorMessage = "Maximo 9 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Numero de Emergencia")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[0-9-]+$", ErrorMessage = "El Numero de Emergencia debe contener solo números")] // Validamos el tipo de dato
        public string NumeroDeEmergencia { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Tipo de Bachillerato es requerido")] //Indica que es un campo requerido
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Tipo de Bachillerato")] // Una tipo traduccion (esto lo vera el cliente)
        public string TipoDeBachillerato { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Titulo Universitario es requerido")] //Indica que es un campo requerido
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Titulo Universitario")] // Una tipo traduccion (esto lo vera el cliente)
        public string TituloUniversitario { get; set; } = string.Empty;

        [Required(ErrorMessage = "La Experiencia Laboral es Requerida")] //Indica que es un campo requerido
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Experiencia Laboral")] // Una tipo traduccion (esto lo vera el cliente)
        public string ExperienciaLaboral { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Area de Especializacion es requerida")] //Indica que es un campo requerido
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Area de Especializacion")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El Area de Especializacion debe contener solo Letras")] // Validamos el tipo de dato
        public string AreaDeEspecializacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Puesto o Cargo es requerido")] //Indica que es un campo requerido
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")] // Indica la longitud maxima para dicho campo
        [Display(Name = "Puesto o Cargo")] // Una tipo traduccion (esto lo vera el cliente) 
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El Puesto o Cargo debe contener solo Letras")] // Validamos el tipo de dato
        public string PuestoOCargo { get; set; } = string.Empty;
        #endregion
    }
}
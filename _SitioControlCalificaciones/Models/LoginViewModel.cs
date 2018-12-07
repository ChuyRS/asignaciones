using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _SitioControlCalificaciones.Models
{
    public class LoginViewModel
    {
        [BindProperty] //Decoracion para enlazar clase de InputModel
        public InputModel Input { get; set; }

        [TempData] //Decora y obtiene los errores en tiempo que ocurre al hacer conexion a la base de datos
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "<font color='red'>El campo de usuario es obligatorio.</font>")]
            public string Usuario { get; set; }

            [Required(ErrorMessage = "<font color='red'>El campo de contraseña es obligatorio.</font>")]
            [DataType(DataType.Password)]
            public string Contraseña { get; set; }
        }
    }
}

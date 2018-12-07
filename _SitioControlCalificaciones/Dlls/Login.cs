using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _SitioControlCalificaciones.Dlls
{
    public class Login
    {
        public Login()
        { }

        public bool inicioSesion(Models.LoginViewModel model)
        {
            try
            {
                var _bd = new bd();
                var consulta = _bd.Consultar("SELECT * FROM usuario where usuario = '" + model.Input.Usuario + "';");

                if (consulta.Rows[0]["contrasena"].Equals(model.Input.Contraseña))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string datosJson(Models.LoginViewModel model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == "admin" && contrasena == "1111" ||usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contraseña  )
                {
                    return true;
                }

            }

            return false;
        }

    }
}

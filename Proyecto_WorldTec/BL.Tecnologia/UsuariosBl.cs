using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
   public class UsuariosBl
    {

        Contexto _contexto;
        public BindingList<Usuario> ListadeUsuarios{ get; set; }


        public UsuariosBl()
        {
            _contexto = new Contexto();
            ListadeUsuarios = new BindingList<Usuario>();
                  
        }

        public BindingList<Usuario> Obtenerusuarios()
        {
            _contexto.Usuarios.Load();
            ListadeUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListadeUsuarios;
        }


        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

      
        public result GuardarUsuario(Usuario usuario)
        {
            var result = Validar(usuario);
            if (result.Exitoso == false) 
            {
                return result;
            }

            _contexto.SaveChanges();
            result.Exitoso = true;
            return result;
        }

        public void AgregarUsuario()
        {
            var nuevousuario = new Usuario();
            _contexto.Usuarios.Add(nuevousuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListadeUsuarios.ToList())
            {
                if (usuario.Id == id)
                {
                    ListadeUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private result Validar(Usuario usuario)
        {
            var result = new result();
            result.Exitoso = true;

            if (usuario == null)
            {
                result.Mensaje = "Agregue un Usuario Valido";
                result.Exitoso = false;

                return result;
            }

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                result.Mensaje = "Ingrese un nombre de usuario Valido";
                result.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Contraseña) == true)
            {
                result.Mensaje = "Ingrese una contraseña Valida";
                result.Exitoso = false;
            }

            return result;
        }

    }

    public class result
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }


    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

    }
}

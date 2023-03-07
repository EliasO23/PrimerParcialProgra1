using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimerParcialProgra1.Entidades;

namespace PrimerParcialProgra1.Negocio
{
    public class ClsUsuario
    {
        public bool Acceso(Usuario user)
        {

            if (user.User.Equals("TuNombre") && user.Contra.Equals("123"))
            {
                return true;

            }
            return false;

        }
    }
}
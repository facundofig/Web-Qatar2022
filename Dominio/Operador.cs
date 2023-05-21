using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Operador : Usuario
    {
        #region Constructores
        public Operador() : base()
        {
        }

        public Operador(string nombre, string apellido, string email, string password) : base(nombre, apellido, email, password)
        {
        }
        #endregion

        #region Mètodos
        public override string GetTipo()
        {
            return "Operador";
        }
        #endregion
    }
}

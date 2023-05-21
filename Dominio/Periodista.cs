﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Periodista: Usuario, IComparable<Periodista>
    {
        #region Constructores
        public Periodista() : base()
        {
        }
        public Periodista(string nombre, string apellido, string email, string password) : base(nombre, apellido, email, password)
        {
        }

        #endregion

        #region Métodos
        public override string GetTipo()
        {
            return "Periodista";
        }
        public int CompareTo([AllowNull] Periodista other)
        {
            if (Apellido.CompareTo(other.Apellido) > 0)
            {
                return 1;
            }
            else if (Apellido.CompareTo(other.Apellido) < 0)
            {
                return -1;
            }
            else
            {
                if (Nombre.CompareTo(other.Nombre) > 0)
                {
                    return 1;
                }
                else if (Nombre.CompareTo(other.Nombre) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion
    }
}

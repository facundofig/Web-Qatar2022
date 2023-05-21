using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pais: IValidable
    {
        #region Properties
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoAlpha3 { get; set; }
        #endregion

        #region Constructores
        public Pais()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Pais(string nombre, string codigoAlpha3)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            CodigoAlpha3 = codigoAlpha3;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"País: {Nombre} - {CodigoAlpha3}";
        }
        public void Valido()
        {
            if (Nombre == "")
            {
                throw new Exception("El nombre no puede ser vacío");
            }
            if (CodigoAlpha3.Length != 3)
            {
                throw new Exception("El código Alpha3 tiene que tener 3 caracteres");
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Pais pais &&
                   Nombre == pais.Nombre;
        }

        #endregion
    }
}

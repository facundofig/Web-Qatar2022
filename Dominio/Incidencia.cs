using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Incidencia: IValidable
    {
        #region Properties
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public Jugador Jugador { get; set; }
        public TipoIncidencia Tipo { get; set; }
        public int Minuto { get; set; }
        #endregion

        #region Constructores
        public Incidencia()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Incidencia(Jugador jugador, TipoIncidencia tipo, int minuto)
        {
            Id = UltimoId;
            UltimoId++;
            Jugador = jugador;
            Tipo = tipo;
            Minuto = minuto;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Incidencia: {Jugador.NombreCompleto} - {Tipo} - {Minuto}";
        }
        public void Valido()
        {
            if (Jugador.Equals(null))
            {
                throw new Exception("El jugador no puede ser null");
            }
            if (Minuto < -1)
            {
                throw new Exception("El minuto no puede ser menor que -1");
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Partido_FaseDeGrupos: Partido
    {
        #region Properties
        public NombreGrupo NombreGrupo { get; set; }
        #endregion

        #region Constructores
        public Partido_FaseDeGrupos(NombreGrupo nombreGrupo, Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora):base(seleccion1, seleccion2, fechaHora)
        {
            NombreGrupo = nombreGrupo;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"{base.ToString()} \n" +
                $"Nombre del grupo: {NombreGrupo}";
        }
        public override string FinalizarPartido()
        {
            Finalizado = true;
            int golesSeleccion1 = 0;
            int golesSeleccion2 = 0;
            foreach (Incidencia i in GetIncidencias())
            {
                if (i.Jugador.Pais.Equals(Seleccion1.Pais) && i.Tipo == TipoIncidencia.Gol)
                {
                    golesSeleccion1++;
                }
                else if (i.Jugador.Pais.Equals(Seleccion2.Pais) && i.Tipo == TipoIncidencia.Gol)
                {
                    golesSeleccion2++;
                }
            }

            if (golesSeleccion1 == golesSeleccion2)
            {
                return "Empate";
            }
            else if (golesSeleccion1 > golesSeleccion2)
            {
                return $"Ganador: {Seleccion1.Pais.Nombre}";
            }
            else
            {
                return $"Ganador: {Seleccion2.Pais.Nombre}";
            }
        }
        public override string GetTipo()
        {
            return "Grupo";
        }
        #endregion
    }
}

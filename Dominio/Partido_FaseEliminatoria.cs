using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Partido_FaseEliminatoria : Partido
    {
        #region Properties
        public bool Alargue { get; set; }
        public bool Penales { get; set; }
        public Etapa Etapa { get; set; }

        #endregion

        #region Constructores
        public Partido_FaseEliminatoria(bool alargue, bool penales, Etapa etapa, Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora) : base(seleccion1, seleccion2, fechaHora)
        {
            Alargue = alargue;
            Penales = penales;
            Etapa = etapa;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"{base.ToString()} \n" +
                $"Alargue: {Alargue} \n" +
                $"Penales: {Penales} \n" +
                $"Etapa: {Etapa}";
        }
        public override void AgregarIncidencia(Jugador j, TipoIncidencia tipo, int min)
        {
            try
            {
                Incidencia i = new Incidencia(j, tipo, min);
                i.Valido();
                if (Seleccion1.GetJugadores().Contains(j) || Seleccion2.GetJugadores().Contains(j))
                {
                    if (min > 120)
                    {
                        i = new Incidencia(j, tipo, -1);
                    }
                    else
                    {
                        i = new Incidencia(j, tipo, min);
                    }
                    GetIncidencias().Add(i);
                }
                else
                {
                    throw new Exception("El jugador tiene que pertenecer a alguna de las selecciones");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            if (!Alargue)
            {
                if (golesSeleccion1 > golesSeleccion2)
                {
                    return $"Ganador: {Seleccion1.Pais.Nombre}";
                }
                else
                {
                    return $"Ganador: {Seleccion2.Pais.Nombre}";
                }
            }
            else if (!Penales)
            {
                if (golesSeleccion1 > golesSeleccion2)
                {
                    return $"Ganador: {Seleccion1.Pais.Nombre} en el alargue";
                }
                else
                {
                    return $"Ganador: {Seleccion2.Pais.Nombre} en el alargue";
                }
            }
            else
            {
                if (golesSeleccion1 > golesSeleccion2)
                {
                    return $"Ganador: {Seleccion1.Pais.Nombre} en tanda de penales";
                }
                else
                {
                    return $"Ganador: {Seleccion2.Pais.Nombre} en tanda de penales";
                }
            }
        }

        public override string GetTipo()
        {
            return "Eliminatorio";
        }
        #endregion
    }
}

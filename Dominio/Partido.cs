using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Partido: IValidable
    {
        #region Properties
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public Seleccion Seleccion1 { get; set; }
        public Seleccion Seleccion2 { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Finalizado { get; set; }
        private List<Incidencia> Incidencias { get; }
        public string ResultadoFinal { get; set; }
        #endregion

        #region Constructores
        public Partido()
        {
            Id = UltimoId;
            UltimoId++;
            Incidencias = new List<Incidencia>();
            ResultadoFinal = "Pendiente";
            Finalizado = false;
        }
        public Partido(Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora)
        {
            Id = UltimoId;
            UltimoId++;
            Incidencias = new List<Incidencia>();
            Seleccion1 = seleccion1;
            Seleccion2 = seleccion2;
            FechaHora = fechaHora;
            ResultadoFinal = "Pendiente";
            Finalizado = false;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Partido: \n" +
                $"Selección 1: {Seleccion1.Pais.Nombre} \n" +
                $"Selección 2: {Seleccion2.Pais.Nombre} \n" +
                $"Fecha y hora: {FechaHora} \n" +
                $"Finalizado: {Finalizado} \n" +
                $"Incidencias: {MostrarIncidencias()}" +
                $"Resultado final: {ResultadoFinal}";    
        }
        public void Valido()
        {
            if (FechaHora < new DateTime(2022, 11, 20) || FechaHora > new DateTime(2022, 12, 18))
            {
                throw new Exception("La fecha tiene que estar comprendida entre el 20/11/2022 y el 18/12/2022");
            }
        }

        //Retorna las incidencias de un partido para imprimirlas
        private string MostrarIncidencias()
        {
            string retorno = "";
            foreach (Incidencia i in Incidencias)
            {
                retorno += i.ToString();
            }
            return retorno;
        }
        public abstract string FinalizarPartido();
        public virtual void AgregarIncidencia(Jugador j, TipoIncidencia tipo, int min)
        {
            try
            {
                Incidencia i = new Incidencia(j, tipo, min);
                i.Valido();
                if (Seleccion1.GetJugadores().Contains(j) || Seleccion2.GetJugadores().Contains(j))
                {
                    Incidencias.Add(i);
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
        public List<Incidencia> GetIncidencias()
        {
            return Incidencias;
        }
        public override bool Equals(object obj)
        {
            return obj is Partido partido &&
                   EqualityComparer<Seleccion>.Default.Equals(Seleccion1, partido.Seleccion1) &&
                   EqualityComparer<Seleccion>.Default.Equals(Seleccion2, partido.Seleccion2) &&
                   FechaHora == partido.FechaHora;
        }

        public abstract string GetTipo();

        #endregion
    }
}

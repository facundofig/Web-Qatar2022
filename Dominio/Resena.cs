using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Resena: IValidable, IComparable<Resena>
    {
        #region Properties
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public Periodista Periodista { get; set; }
        public DateTime Fecha { get; set; }
        public Partido Partido { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        #endregion

        #region Constructores
        public Resena()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Resena(Periodista periodista, DateTime fecha, Partido partido, string titulo, string contenido)
        {
            Id = UltimoId;
            UltimoId++;
            Periodista = periodista;
            Fecha = fecha;
            Partido = partido;
            Titulo = titulo;
            Contenido = contenido;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Reseña: \n" +
                $"Id: {Id} \n" +
                $"Periodista: {Periodista.Nombre} {Periodista.Apellido} \n" +
                $"Fecha: {Fecha} \n" +
                $"Partido: {Partido.Seleccion1} - {Partido.Seleccion2} \n" +
                $"Título: {Titulo} \n" +
                $"Contenido: {Contenido}";
        }
        public void Valido()
        {
            if (Periodista.Equals(null))
            {
                throw new Exception("El periodista no puede ser null");
            }
            if (Fecha.Equals(null))
            {
                throw new Exception("La fecha no puede ser null");
            }
            if (Partido.Equals(null))
            {
                throw new Exception("El partido no puede ser null");
            }
            if (string.IsNullOrEmpty(Titulo))
            {
                throw new Exception("El título no puede ser vacío");
            }
            if (string.IsNullOrEmpty(Contenido))
            {
                throw new Exception("El contenido no puede ser vacío");
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Resena resena &&
                   EqualityComparer<Periodista>.Default.Equals(Periodista, resena.Periodista) &&
                   EqualityComparer<Partido>.Default.Equals(Partido, resena.Partido) &&
                   Titulo == resena.Titulo &&
                   Contenido == resena.Contenido;
        }

        public int CompareTo([AllowNull] Resena other)
        {
            if (Fecha.CompareTo(other.Fecha) > 0)
            {
                return -1;
            }
            else if (Fecha.CompareTo(other.Fecha) < 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }
}

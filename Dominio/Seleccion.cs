using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Seleccion: IValidable, IComparable<Seleccion>
    {
        #region Properties
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public Pais Pais { get; set; }
        private List<Jugador> Jugadores { get; set; }
        #endregion

        #region Constructores
        public Seleccion()
        {
            Id = UltimoId;
            UltimoId++;
            Jugadores = new List<Jugador>();
        }

        public Seleccion(Pais pais)
        {
            Id = UltimoId;
            UltimoId++;
            Jugadores = new List<Jugador>();
            Pais = pais;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Selección: \n" +
                $"Pais: {Pais.Nombre} \n" +
                $"Jugadores: {MostrarJugadores()}";
        }

        //Retorna los jugadores de una selección para imprimirlos
        private string MostrarJugadores()
        {
            string retorno = "";
            foreach (Jugador j in Jugadores)
            {
                retorno += $"{j.NombreCompleto} \n";
            }
            return retorno;
        }
        public void Valido()
        {
            if (Pais.Equals(null))
            {
                throw new Exception("El país no puede ser null");
            }
            if (Jugadores.Count < 11)
            {
                throw new Exception("La selección tiene que tener al menos 11 jugadores");
            }
        }
        public void AgregarJugador(Jugador j)
        {
            try
            {
                j.Valido();
                Jugadores.Add(j);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Jugador> GetJugadores()
        {
            return Jugadores;
        }
        public override bool Equals(object obj)
        {
            return obj is Seleccion seleccion &&
                   EqualityComparer<Pais>.Default.Equals(Pais, seleccion.Pais);
        }

        public int CompareTo([AllowNull] Seleccion other)
        {
            if (Pais.Nombre.CompareTo(other.Pais.Nombre) > 0)
            {
                return 1;
            }
            else if (Pais.Nombre.CompareTo(other.Pais.Nombre) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Jugador : IValidable, IComparable<Jugador>
    {
        #region Properties
        public int Id { get; set; }
        public string NroCamiseta { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; }
        public string PieHabil { get; set; }
        public double ValorMercado { get; set; }
        public string Moneda { get; set; }
        public Pais Pais { get; set; }
        public string Puesto { get; set; }
        public static double MontoCategoria { get; set; }
        #endregion

        #region Constructores
        public Jugador()
        {

        }
        public Jugador(int id, string nroCamiseta, string nombreCompleto, DateTime fechaNacimiento, double altura, string pieHabil, double valorMercado, string moneda, Pais pais, string puesto)
        {
            Id = id;
            NroCamiseta = nroCamiseta;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PieHabil = pieHabil;
            ValorMercado = valorMercado;
            Moneda = moneda;
            Pais = pais;
            Puesto = puesto;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Jugador: \n" +
                $"Nombre completo: {NombreCompleto} \n" +
                $"Número de camiseta: {NroCamiseta} \n" +
                $"Fecha de nacimiento: {FechaNacimiento} \n" +
                $"Altura: {Altura} \n" +
                $"Pie hábil: {PieHabil} \n" +
                $"Valor de mercado: {ValorMercado} \n" +
                $"Pais: {Pais.Nombre} \n" +
                $"Puesto: {Puesto} \n" +
                $"Categoría financiera: {CategoriaFinanciera()}";
        }
        public void Valido()
        {
            if (NombreCompleto == "")
            {
                throw new Exception("El nombre no puede ser vacío");
            }
            if (NroCamiseta == "")
            {
                throw new Exception("El número de camiseta no puede ser vacío");
            }
            if (FechaNacimiento.Equals(null))
            {
                throw new Exception("La fecha de nacimiento no puede ser null");
            }
            if (Altura < 0)
            {
                throw new Exception("La altura tiene que ser mayor o igual que cero");
            }
            if (PieHabil == "")
            {
                throw new Exception("El pie hábil no puede ser vacío");
            }
            if (ValorMercado < 0)
            {
                throw new Exception("El valor de mercado tiene que ser mayor que cero");
            }
            if (Pais.Equals(null))
            {
                throw new Exception("El país no puede ser null");
            }
            if (Puesto == "")
            {
                throw new Exception("El puesto no puede ser vacío");
            }
        }
        public string CategoriaFinanciera()
        {
            if (ValorMercado < MontoCategoria)
            {
                return "Estándar";
            }
            else
            {
                return "VIP";
            }
        }
        public int CompareTo([AllowNull] Jugador other)
        {
            if (ValorMercado.CompareTo(other.ValorMercado) > 0)
            {
                return 1;
            }
            else if (ValorMercado.CompareTo(other.ValorMercado) < 0)
            {
                return -1;
            }
            else
            {
                if (NombreCompleto.CompareTo(other.NombreCompleto) < 0)
                {
                    return 1;
                }
                else if (NombreCompleto.CompareTo(other.NombreCompleto) > 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Jugador jugador &&
                   NroCamiseta == jugador.NroCamiseta &&
                   NombreCompleto == jugador.NombreCompleto &&
                   EqualityComparer<Pais>.Default.Equals(Pais, jugador.Pais);
        }

        #endregion
    }
}

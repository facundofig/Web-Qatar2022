using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Usuario: IValidable
    {
        #region Properties
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        #endregion

        #region Constructores
        public Usuario()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Usuario(string nombre, string apellido, string email, string password)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Usuario: \n" +
                $"Nombre: {Nombre} \n" +
                $"Apellido: {Apellido} \n" +
                $"Email: {Email} \n" +
                $"Password: {Password}";
        }
        public void Valido()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre no puede ser vacío");
            }
            if (String.IsNullOrEmpty(Apellido))
            {
                throw new Exception("El apellido no puede ser vacío");
            }
            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("El email no puede ser vacío");
            }
            if (String.IsNullOrEmpty(Password))
            {
                throw new Exception("La password no puede ser vacía");
            }
            if (Email.IndexOf('@') == -1)
            {
                throw new Exception("El email debe contener @");
            }
            if (Email.IndexOf('@') == 0 || Email.IndexOf('@') == Email.Length - 1)
            {
                throw new Exception("El @ no puede estar en la primera ni en la última posición");
            }
            if (Password.Length < 8)
            {
                throw new Exception("La password tiene que contener al menos 8 caracteres");
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   Email == usuario.Email;
        }

        public abstract string GetTipo();

        #endregion
    }
}

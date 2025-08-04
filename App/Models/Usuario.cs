using System.Text.RegularExpressions;


namespace App.Models
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; } = "";
        public string Apellido { get; private set; } = "";
        public string Email { get; private set; } = "";
        public string Clave { get; private set; } = "";
        public bool Habilitado { get; private set; } = true;
        public string NombreUsuario { get; private set; } = "";

        public Usuario(int id, string nombre, string apellido, string email, string clave, bool habilitado, string nombreUsuario)
        {
            SetId(id);
            SetNombre(nombre);
            SetApellido(apellido);
            SetEmail(email);
            SetClave(clave);
            SetHabilitado(habilitado);
            SetNombreUsuario(nombreUsuario);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.");
            Nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El apellido no puede ser nulo o vacío.");
            Apellido = apellido;
        }

        public void SetEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("El email no tiene un formato válido.");
            Email = email;
        }

        public void SetClave(string clave)
        {
            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("La clave no puede estar vacía.");
            Clave = clave;
        }

        public void SetHabilitado(bool habilitado)
        {
            habilitado = true;
            Habilitado = habilitado;
        }

        public void SetNombreUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            NombreUsuario = nombreUsuario;
        }
    }
}

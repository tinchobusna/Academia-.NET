using System.Collections.Generic;
using App.Models;

namespace App.Context
{
    public static class FakeDbContext
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>
        {
            new Usuario(1, "Juan", "Pérez", "juan.perez@email.com", "clave123", true, "juanp"),
            new Usuario(2, "Ana", "Gómez", "ana.gomez@email.com", "clave456", true, "anag")
        };

        public static List<Curso> Cursos { get; set; } = new List<Curso>
        {
            new Curso(1, 2000, 30, "matematica", 12, 1),
            new Curso(2, 2001, 40, "Ide", 10, 2)
        };
    }
}

using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Context;
namespace App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(FakeDbContext.Usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            var usuario = FakeDbContext.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
                return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult CrearUsuario([FromBody] Usuario usuario)
        {
            if (FakeDbContext.Usuarios.Any(u => u.Id == usuario.Id))
                return BadRequest("Ya existe un usuario con ese ID.");

            FakeDbContext.Usuarios.Add(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult ModificarUsuario(int id, [FromBody] Usuario usuarioEditado)
        {
            var usuario = FakeDbContext.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
                return NotFound();

            usuario.SetNombre(usuarioEditado.Nombre);
            usuario.SetApellido(usuarioEditado.Apellido);
            usuario.SetEmail(usuarioEditado.Email);
            usuario.SetClave(usuarioEditado.Clave);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarUsuario(int id)
        {
            var usuario = FakeDbContext.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null)
                return NotFound();

            FakeDbContext.Usuarios.Remove(usuario);
            return NoContent();
        }
    }
}


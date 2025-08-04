using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Context;

namespace App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCursos()
        {
            return Ok(FakeDbContext.Cursos);
        }

        [HttpGet("{id}")]
        public IActionResult GetCurso(int id)
        {
            var curso = FakeDbContext.Cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
                return NotFound();
            return Ok(curso);
        }

        [HttpPost]
        public IActionResult CrearCurso([FromBody] Curso curso)
        {
            if (FakeDbContext.Cursos.Any(c => c.Id == curso.Id))
                return BadRequest("Ya existe un curso con ese ID.");

            FakeDbContext.Cursos.Add(curso);
            return CreatedAtAction(nameof(GetCurso), new { id = curso.Id }, curso);
        }

        [HttpPut("{id}")]
        public IActionResult ModificarCurso(int id, [FromBody] Curso cursoEditado)
        {
            var curso = FakeDbContext.Cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
                return NotFound();

            curso.SetAnioCalendario(cursoEditado.AnioCalendario);
            curso.SetCupo(cursoEditado.Cupo);
            curso.SetDescripcion(cursoEditado.Descripcion);
            curso.SetIdComision(cursoEditado.IdComision);
            curso.SetIdMateria(cursoEditado.IdMateria);

            return Ok(curso);
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarCurso(int id)
        {
            var curso = FakeDbContext.Cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
                return NotFound();

            FakeDbContext.Cursos.Remove(curso);
            return NoContent();
        }
    }
}

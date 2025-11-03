using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class ProfesorCursoRepository
    {
        private TPIContext CreateContext()
        {
            return new TPIContext();
        }

        public async Task Add(ProfesorCurso profesorCurso)
        {
            await using var context = CreateContext();
            await context.ProfesoresCursos.AddAsync(profesorCurso);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProfesorCurso?>?> FindByCriteria(ProfesorCursoCriteria criteria)
        {
            await using var context = CreateContext();

            return await context.ProfesoresCursos
                .Where(u => u.IdProfesor == criteria.IdProfesor)
                .ToListAsync();
        }

        //public async Task<bool> Update(ProfesorCurso profesorCurso)
        //{
        //    await using var context = CreateContext();
        //    var existingprofesorCurso = await context.ProfesoresCursos.FindAsync(profesorCurso.IdAsignacion);
        //    if (existingprofesorCurso != null)
        //    {
        //        existingprofesorCurso.SetCursoId(profesorCurso.IdCurso);
        //        existingprofesorCurso.SetProfesorId(profesorCurso.IdProfesor);
        //        existingprofesorCurso.Cargo = profesorCurso.Cargo;

        //        await context.SaveChangesAsync();
        //        return true;
        //    }
        //    return false;
        //}

        public async Task<bool> Update(ProfesorCurso profesorCurso)
        {
            await using var context = CreateContext();
            var existente = await context.ProfesoresCursos
                .FirstOrDefaultAsync(dc => dc.IdCurso == profesorCurso.IdCurso && dc.IdProfesor == profesorCurso.IdProfesor);

            if (existente == null)
                return false;

            existente.Cargo = profesorCurso.Cargo;
            // Si necesitas actualizar otros campos, hazlo aquí

            await context.SaveChangesAsync();
            return true;
        }
    }
}

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

        public async Task Add(ProfesorCurso ProfesorCurso)
        {
            await using var context = CreateContext();
            await context.ProfesoresCursos.AddAsync(ProfesorCurso);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProfesorCurso?>?> FindByCriteria(ProfesorCursoCriteria criteria)
        {
            await using var context = CreateContext();

            return await context.ProfesoresCursos
                .Where(u => u.IdProfesor == criteria.IdProfesor)
                .ToListAsync();
        }
    }
}

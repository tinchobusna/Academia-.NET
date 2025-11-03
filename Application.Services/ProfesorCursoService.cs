using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ProfesorCursoService
    {
        public async Task<ProfesorCursoDTO> Add(ProfesorCursoDTO dto)
        {
            var profesorCursoRepository = new ProfesorCursoRepository();

            ProfesorCurso profesorCurso = new ProfesorCurso(dto.Cargo, dto.IdCurso, dto.IdProfesor);

            await profesorCursoRepository.Add(profesorCurso);

            dto.IdCurso = profesorCurso.IdCurso;
            dto.IdProfesor = profesorCurso.IdProfesor;

            return dto;
        }

        public async Task<IEnumerable<ProfesorCursoDTO>> GetByCriteria(ProfesorCursoCriteriaDTO criteriaDto)
        {
            var criteria = new ProfesorCursoCriteria
            {
                IdProfesor = criteriaDto.IdProfesor
            };

            var profesorCursoRepository = new ProfesorCursoRepository();

            var entidades = await profesorCursoRepository.FindByCriteria(criteria);

            var dtos = entidades.Select(dc => new ProfesorCursoDTO
            {
                IdCurso = dc.IdCurso,
                IdProfesor = dc.IdProfesor,
                Cargo = dc.Cargo
            }).ToList();

            return dtos;
        }
        /*
        public async Task<bool> Update(ProfesorCursoDTO dto)
        {
            var profesorCursoRepository = new ProfesorCursoRepository();

            ProfesorCurso profesorCurso = new ProfesorCurso(dto.Cargo, dto.IdProfesor, dto.IdAsignacion); //Que va aca?
            profesorCurso.SetCursoId(dto.IdCurso);
            profesorCurso.SetProfesorId(dto.IdProfesor);
            return await profesorCursoRepository.Update(profesorCurso);
        }*/
        public async Task<bool> UpdateByCursoProfesor(ProfesorCursoDTO dto)
        {
            var profesorCursoRepository = new ProfesorCursoRepository();

            // Buscar la asignación existente por IdCurso e IdProfesor
            var criterios = new ProfesorCursoCriteria { IdCurso = dto.IdCurso, IdProfesor = dto.IdProfesor };
            var existentes = await profesorCursoRepository.FindByCriteria(criterios);
            var existente = existentes?.FirstOrDefault();

            if (existente == null)
                return false;

            existente.Cargo = dto.Cargo;
            // Si quieres permitir cambiar el profesor o curso, puedes actualizar los IDs aquí

            return await profesorCursoRepository.Update(existente);
        }

    }
}

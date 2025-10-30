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
            var ProfesorCursoRepository = new ProfesorCursoRepository();

            ProfesorCurso ProfesorCurso = new ProfesorCurso(dto.Cargo, dto.IdCurso, dto.IdProfesor);

            await ProfesorCursoRepository.Add(ProfesorCurso);

            dto.IdCurso = ProfesorCurso.IdCurso;
            dto.IdProfesor = ProfesorCurso.IdProfesor;

            return dto;
        }

        public async Task<IEnumerable<ProfesorCursoDTO>> GetByCriteria(ProfesorCursoCriteriaDTO criteriaDto)
        {
            var criteria = new ProfesorCursoCriteria
            {
                IdProfesor = criteriaDto.IdProfesor
            };

            var ProfesorCursoRepository = new ProfesorCursoRepository();

            var entidades = await ProfesorCursoRepository.FindByCriteria(criteria);

            var dtos = entidades.Select(dc => new ProfesorCursoDTO
            {
                IdCurso = dc.IdCurso,
                IdProfesor = dc.IdProfesor,
                Cargo = dc.Cargo
            }).ToList();

            return dtos;
        }

        public async Task<bool> Update(ProfesorCursoDTO dto)
        {
            var ProfesorCursoRepository = new ProfesorCursoRepository();

            ProfesorCurso ProfesorCurso = new ProfesorCurso(dto.IdAsignacion, dto.Cargo);
            ProfesorCurso.SetCursoId(dto.IdCurso);
            ProfesorCurso.SetProfesorId(dto.IdProfesor);
            return await ProfesorCursoRepository.Update(ProfesorCurso);
        }
    }
}

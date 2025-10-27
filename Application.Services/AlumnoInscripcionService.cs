﻿using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class AlumnoInscripcionService
    {
        public AlumnoInscripcionDTO Add(AlumnoInscripcionDTO dto)
        {
            var alumnoInscripcionRepository = new AlumnoInscripcionRepository();

            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion(0, dto.Condicion, dto.Nota);
            alumnoInscripcion.SetCursoId(dto.IdCurso);
            alumnoInscripcion.SetAlumnoId(dto.IdAlumno);

            alumnoInscripcionRepository.Add(alumnoInscripcion);

            dto.IdInscripcion = alumnoInscripcion.IdInscripcion;

            return dto;
        }

        public bool Delete(int id)
        {
            var alumnoInscripcionRepository = new AlumnoInscripcionRepository();
            return alumnoInscripcionRepository.Delete(id);
        }

        public AlumnoInscripcionDTO Get(int id)
        {
            var alumnoInscripcionRepository = new AlumnoInscripcionRepository();
            AlumnoInscripcion? alumnoInscripcion = alumnoInscripcionRepository.Get(id);

            if (alumnoInscripcion == null)
                return null;

            return new AlumnoInscripcionDTO
            {
                IdInscripcion = alumnoInscripcion.IdInscripcion,
                Condicion = alumnoInscripcion.Condicion,
                Nota = alumnoInscripcion.Nota,
                IdCurso = alumnoInscripcion.IdCurso,
                IdAlumno = alumnoInscripcion.IdAlumno,
            };
        }

        public IEnumerable<AlumnoInscripcionDTO> GetAll()
        {
            var alumnoInscripcionRepository = new AlumnoInscripcionRepository();
            var alumnosInscripciones = alumnoInscripcionRepository.GetAll();

            return alumnosInscripciones.Select(alumnoInscripcion => new AlumnoInscripcionDTO
            {
                IdInscripcion = alumnoInscripcion.IdInscripcion,
                Condicion = alumnoInscripcion.Condicion,
                Nota = alumnoInscripcion.Nota,
                IdCurso = alumnoInscripcion.IdCurso,
                IdAlumno = alumnoInscripcion.IdAlumno,
            }).ToList();
        }

        public bool Update(AlumnoInscripcionDTO dto)
        {
            var alumnoInscripcionRepository = new AlumnoInscripcionRepository();

            string condicion = dto.Condicion;
            AlumnoInscripcion alumnoInscripcion = new AlumnoInscripcion(dto.IdInscripcion, condicion, dto.Nota);
            alumnoInscripcion.SetCursoId(dto.IdCurso);
            alumnoInscripcion.SetAlumnoId(dto.IdAlumno);
            return alumnoInscripcionRepository.Update(alumnoInscripcion);
        }

        //public IEnumerable<ComisionDTO> GetByCriteria(ComisionCriteriaDTO criteriaDTO)
        //{
        //    var comisionRepository = new ComisionRepository();

        //    // Mapear DTO a Domain Model
        //    var criteria = new ComisionCriteria(criteriaDTO.Texto);

        //    // Llamar al repositorio
        //    var comisiones = comisionRepository.GetByCriteria(criteria);

        //    // Mapear Domain Model a DTO
        //    return comisiones.Select(c => new ComisionDTO
        //    {
        //        IdComision = c.IdComision,
        //        AnioEspecialidad = c.AnioEspecialidad,
        //        Descripcion = c.Descripcion,
        //        IdPlan = c.IdPlan,
        //    });
        //}

    }
}
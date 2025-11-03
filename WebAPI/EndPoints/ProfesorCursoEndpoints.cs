using DTOs;
using Application.Services;
using Microsoft.AspNetCore.Http;

namespace ProfesorCursoAPI.EndPoints
{
    public static class ProfesorCursoEndpoints
    {
        public static void MapProfesorCursoEndpoints(this WebApplication app)
        {
            app.MapPost("/ProfesoresCursos", async (ProfesorCursoDTO dto) =>
            {
                try
                {
                    ProfesorCursoService ProfesorCursoService = new ProfesorCursoService();

                    ProfesorCursoDTO ProfesorCursoDTO = await ProfesorCursoService.Add(dto);

                    return Results.Created(
                        $"/ProfesoresCursos/{ProfesorCursoDTO.IdProfesor}/{ProfesorCursoDTO.IdCurso}",
                        ProfesorCursoDTO
                    );

                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddProfesorCurso")
            .Produces<ProfesorCursoDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapGet("/ProfesoresCursos/criteria", async (int idProfesor) =>
            {
                try
                {
                    ProfesorCursoService ProfesorCursoService = new ProfesorCursoService();
                    var criteria = new ProfesorCursoCriteriaDTO { IdProfesor = idProfesor };
                    var ProfesoresCursos = await ProfesorCursoService.GetByCriteria(criteria);
                    return Results.Ok(ProfesoresCursos);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("GetProfesorCursoByCriteria")
            .WithOpenApi();

            app.MapPut("/ProfesoresCursos/{idCurso}/{idProfesor}", async (int idCurso, int idProfesor, ProfesorCursoDTO dto) =>
            {
                try
                {
                    ProfesorCursoService ProfesorCursoService = new ProfesorCursoService();

                    dto.IdCurso = idCurso;
                    dto.IdProfesor = idProfesor;

                    var found = await ProfesorCursoService.UpdateByCursoProfesor(dto);

                    if (!found)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdateProfesorCursoByCursoProfesor")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}


using DTOs;
using Domain.Model;
using Microsoft.AspNetCore.Http;

namespace WebAPI.EndPoints
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
                    var ProfesorsCursos = await ProfesorCursoService.GetByCriteria(criteria);
                    return Results.Ok(ProfesoresCursos);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("GetProfesorCursoByCriteria")
            .WithOpenApi();


            app.MapPut("/ProfesoresCursos/{id}", async (ProfesorCursoDTO dto) =>
            {
                try
                {
                    ProfesorCursoService ProfesorCursoService = new ProfesorCursoService();

                    var found = await ProfesorCursoService.Update(dto);

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
            .WithName("UpdateProfesorCurso")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace API.ProfesoresCursos
{
    public class ProfesorCursoApiClient
    {
        private static HttpClient client = new HttpClient();
        static ProfesorCursoApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5039/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<IEnumerable<ProfesorCursoDTO?>> GetProfesorCursoByCriteria(int idProfesor)
        {

            var criteria = new ProfesorCursoCriteriaDTO { IdProfesor = idProfesor };

            var response = await client.GetAsync($"profesoresCursos/criteria?idProfesor={criteria.IdProfesor}");

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<IEnumerable<ProfesorCursoDTO?>>();

            return null;
        }


        public async static Task AddAsync(ProfesorCursoDTO profesorCursoDTO)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("profesoresCursos", profesorCursoDTO);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al crear profesorCurso. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al crear profesorCurso: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al crear profesorCurso: {ex.Message}", ex);
            }
        }
        /*
        public static async Task UpdateAsync(ProfesorCursoDTO profesorCurso)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"profesoresCursos/{profesorCurso.IdAsignacion}", profesorCurso);


                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar asignacion con Id {profesorCurso.IdAsignacion}. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar asignacion con Id {profesorCurso.IdAsignacion}: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar asignacion con Id {profesorCurso.IdAsignacion}: {ex.Message}", ex);
            }
        }*/

        public static async Task UpdateByCursoProfesorAsync(ProfesorCursoDTO profesorCurso)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                    $"profesoresCursos/{profesorCurso.IdCurso}/{profesorCurso.IdProfesor}", profesorCurso);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al actualizar asignación. Status: {response.StatusCode}, Detalle: {errorContent}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión al actualizar asignación: {ex.Message}", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception($"Timeout al actualizar asignación: {ex.Message}", ex);
            }
        }
    }
}

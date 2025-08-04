using Entidades;
using Newtonsoft.Json;

namespace Negocio
{
    public class AlumnoNegocio
    {
        public async static Task<IEnumerable<Alumno>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7065;http://localhost:5162");
            var data = JsonConvert.DeserializeObject<List<Alumno>>(response);
            return data;
        }


    }
}

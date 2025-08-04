namespace App.Models
{
    public class Curso
    {
        public int Id { get; private set; }
        public int AnioCalendario { get; private set; }
        public int Cupo { get; private set; }
        public string Descripcion { get; private set; } = "";
        public int IdComision { get; private set; }
        public int IdMateria { get; private set; }

        public Curso(int id, int anioCalendario, int cupo, string descripcion, int idComision, int idMateria)
        {
            SetId(id);
            SetAnioCalendario(anioCalendario);
            SetCupo(cupo);
            SetDescripcion(descripcion);
            SetIdComision(idComision);
            SetIdMateria(idMateria);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor o igual a 0.");
            Id = id;
        }

        public void SetAnioCalendario(int anio)
        {
            if (anio < 1900 || anio > DateTime.Now.Year + 1)
                throw new ArgumentException("El año calendario no es válido.");
            AnioCalendario = anio;
        }

        public void SetCupo(int cupo)
        {
            if (cupo <= 0)
                throw new ArgumentException("El cupo debe ser mayor que 0.");
            Cupo = cupo;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.");
            Descripcion = descripcion;
        }

        public void SetIdComision(int idComision)
        {
            if (idComision <= 0)
                throw new ArgumentException("El ID de comisión debe ser mayor que 0.");
            IdComision = idComision;
        }

        public void SetIdMateria(int idMateria)
        {
            if (idMateria <= 0)
                throw new ArgumentException("El ID de materia debe ser mayor que 0.");
            IdMateria = idMateria;
        }
    }
}

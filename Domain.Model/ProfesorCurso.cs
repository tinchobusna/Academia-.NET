namespace Domain.Model
{
    public class ProfesorCurso
    {

        public string Cargo { get; set; }

        // Atributos para la relacion con curso

        private int _cursoId;
        private Curso? _curso;

        public int IdCurso
        {
            get => _curso?.IdCurso ?? _cursoId;
            private set => _cursoId = value;
        }

        public Curso? Curso
        {
            get => _curso;
            private set
            {
                _curso = value;
                if (value != null && _cursoId != value.IdCurso)
                {
                    _cursoId = value.IdCurso;
                }
            }
        }


        // Atributos para la relacion con Persona ("Profesor")

        private int _profesorId;
        private Persona? _profesor;

        public int IdProfesor
        {
            get => _profesor?.IdPersona ?? _profesorId;
            private set => _profesorId = value;
        }

        public Persona? Profesor
        {
            get => _profesor;
            private set
            {
                _profesor = value;
                if (value != null && _profesorId != value.IdPersona)
                {
                    _profesorId = value.IdPersona;
                }
            }
        }

        public ProfesorCurso() { }

        public ProfesorCurso(string cargo, int idCurso, int idPersona)
        {
            Cargo = cargo;
            IdCurso = idCurso;
            IdProfesor = idPersona;
        }

        public void SetCursoId(int idCurso)
        {
            if (idCurso <= 0)
                throw new ArgumentException("El idCurso debe ser mayor que 0.", nameof(idCurso));

            _cursoId = idCurso;

            if (_curso != null && _curso.IdCurso != idCurso)
            {
                _curso = null;
            }
        }

        public void SetCurso(Curso curso)
        {
            ArgumentNullException.ThrowIfNull(curso);
            _curso = curso;
            _cursoId = curso.IdCurso;
        }

        public void SetProfesorId(int idProfesor)
        {
            if (idProfesor <= 0)
                throw new ArgumentException("El id del Profesor debe ser mayor que 0.", nameof(idProfesor));

            _profesorId = idProfesor;

            if (_profesor != null && _profesor.IdPersona != idProfesor)
            {
                _profesor = null;
            }
        }

        public void SetProfesor(Persona profesor)
        {
            ArgumentNullException.ThrowIfNull(profesor);
            _profesor = profesor;
            _profesorId = profesor.IdPersona;
        }
    }


}


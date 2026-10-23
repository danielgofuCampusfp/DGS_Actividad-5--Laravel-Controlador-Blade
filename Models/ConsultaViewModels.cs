namespace ConsultasLINQ.Models
{
    public class AlumnoNotaViewModel
    {
        public string Nombre { get; set; } = string.Empty;
        public double NotaMedia { get; set; }
    }

    public class AlumnoEdadViewModel
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
    }

    public class AlumnoListadoViewModel
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Ciclo { get; set; } = string.Empty;
    }

    public class AlumnoDestacadoViewModel
    {
        public string Nombre { get; set; } = string.Empty;
        public string Curso { get; set; } = string.Empty;
        public string Ciclo { get; set; } = string.Empty;
        public double NotaMedia { get; set; }
    }

    public class NotaMediaGeneralViewModel
    {
        public double NotaMediaGeneral { get; set; }
        public int TotalAlumnos { get; set; }
    }

    public class MejorExpedienteViewModel
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Curso { get; set; } = string.Empty;
        public string Ciclo { get; set; } = string.Empty;
        public double NotaMedia { get; set; }
    }

    public class CursoAgrupadoViewModel
    {
        public string NombreCurso { get; set; } = string.Empty;
        public int NumeroAlumnos { get; set; }
    }

    public class CicloAgrupadoViewModel
    {
        public string NombreCiclo { get; set; } = string.Empty;
        public int NumeroAlumnos { get; set; }
        public List<string> Alumnos { get; set; } = new();
    }
}

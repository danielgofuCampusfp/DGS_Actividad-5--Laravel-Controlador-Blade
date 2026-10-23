namespace ConsultasLINQ.Models
{
    public class Alumno
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public double NotaMedia { get; set; }
        public Curso Curso { get; set; } = new Curso();
    }
}

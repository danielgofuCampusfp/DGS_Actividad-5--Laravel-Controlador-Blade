using ConsultasLINQ.Models;

namespace ConsultasLINQ
{
    public class Program
    {
        public static List<Alumno> Alumnos { get; } = new()
        {
            new Alumno
            {
                Nombre = "Carlos",
                Edad = 19,
                NotaMedia = 7.5,
                Curso = new Curso { Nombre = "1º DAM", Ciclo = "DAM", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Lucía",
                Edad = 20,
                NotaMedia = 8.7,
                Curso = new Curso { Nombre = "1º DAM", Ciclo = "DAM", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Mario",
                Edad = 22,
                NotaMedia = 5.8,
                Curso = new Curso { Nombre = "1º DAM", Ciclo = "DAM", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Ana",
                Edad = 21,
                NotaMedia = 9.2,
                Curso = new Curso { Nombre = "2º DAM", Ciclo = "DAM", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "David",
                Edad = 23,
                NotaMedia = 6.4,
                Curso = new Curso { Nombre = "2º DAM", Ciclo = "DAM", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Elena",
                Edad = 20,
                NotaMedia = 7.9,
                Curso = new Curso { Nombre = "2º DAM", Ciclo = "DAM", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Pablo",
                Edad = 18,
                NotaMedia = 6.8,
                Curso = new Curso { Nombre = "1º DAW", Ciclo = "DAW", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Sara",
                Edad = 19,
                NotaMedia = 9.1,
                Curso = new Curso { Nombre = "1º DAW", Ciclo = "DAW", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Javier",
                Edad = 21,
                NotaMedia = 5.5,
                Curso = new Curso { Nombre = "1º DAW", Ciclo = "DAW", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Marta",
                Edad = 22,
                NotaMedia = 8.3,
                Curso = new Curso { Nombre = "2º DAW", Ciclo = "DAW", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Álvaro",
                Edad = 24,
                NotaMedia = 7.2,
                Curso = new Curso { Nombre = "2º DAW", Ciclo = "DAW", HorasSemanales = 30 }
            },
            new Alumno
            {
                Nombre = "Raúl",
                Edad = 20,
                NotaMedia = 4.9,
                Curso = new Curso { Nombre = "2º DAW", Ciclo = "DAW", HorasSemanales = 30 }
            }
        };

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

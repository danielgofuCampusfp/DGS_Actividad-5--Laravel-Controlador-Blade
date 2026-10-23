using ConsultasLINQ.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasLINQ.Controllers
{
    public class ConsultasController : Controller
    {
        public IActionResult Consulta1()
        {
            var alumnos = Program.Alumnos
                .Where(a => a.Curso.Nombre == "1º DAM")
                .Select(a => new AlumnoNotaViewModel
                {
                    Nombre = a.Nombre,
                    NotaMedia = a.NotaMedia
                })
                .ToList();

            return View(alumnos);
        }

        public IActionResult Consulta2()
        {
            var alumnos = Program.Alumnos
                .Where(a => a.Edad > 20)
                .OrderBy(a => a.Edad)
                .Select(a => new AlumnoEdadViewModel
                {
                    Nombre = a.Nombre,
                    Edad = a.Edad
                })
                .ToList();

            return View(alumnos);
        }

        public IActionResult Consulta3()
        {
            var alumnos = Program.Alumnos
                .Where(a => a.NotaMedia >= 7)
                .Select(a => new AlumnoNotaViewModel
                {
                    Nombre = a.Nombre,
                    NotaMedia = a.NotaMedia
                })
                .ToList();

            return View(alumnos);
        }

        public IActionResult Consulta4()
        {
            var alumnos = Program.Alumnos
                .Select(a => new AlumnoListadoViewModel
                {
                    Nombre = a.Nombre,
                    Edad = a.Edad,
                    Ciclo = a.Curso.Ciclo
                })
                .ToList();

            return View(alumnos);
        }

        public IActionResult Consulta5()
        {
            var alumnos = Program.Alumnos
                .Where(a => a.Curso.Ciclo == "DAW" && a.NotaMedia > 8)
                .Select(a => new AlumnoDestacadoViewModel
                {
                    Nombre = a.Nombre,
                    Curso = a.Curso.Nombre,
                    Ciclo = a.Curso.Ciclo,
                    NotaMedia = a.NotaMedia
                })
                .ToList();

            return View(alumnos);
        }

        public IActionResult Consulta6()
        {
            var alumnos = Program.Alumnos
                .OrderByDescending(a => a.NotaMedia)
                .Select(a => new AlumnoNotaViewModel
                {
                    Nombre = a.Nombre,
                    NotaMedia = a.NotaMedia
                })
                .ToList();

            return View(alumnos);
        }

        public IActionResult Consulta7()
        {
            var alumnos = Program.Alumnos;
            var notaMediaGeneral = alumnos.Any() ? alumnos.Average(a => a.NotaMedia) : 0;

            var model = new NotaMediaGeneralViewModel
            {
                NotaMediaGeneral = notaMediaGeneral,
                TotalAlumnos = alumnos.Count()
            };

            return View(model);
        }

        public IActionResult Consulta8()
        {
            var alumno = Program.Alumnos
                .OrderByDescending(a => a.NotaMedia)
                .FirstOrDefault();

            var model = alumno is null
                ? null
                : new MejorExpedienteViewModel
                {
                    Nombre = alumno.Nombre,
                    Edad = alumno.Edad,
                    Curso = alumno.Curso.Nombre,
                    Ciclo = alumno.Curso.Ciclo,
                    NotaMedia = alumno.NotaMedia
                };

            return View(model);
        }

        public IActionResult Consulta9()
        {
            var grupos = Program.Alumnos
                .GroupBy(a => a.Curso.Nombre)
                .Select(g => new CursoAgrupadoViewModel
                {
                    NombreCurso = g.Key,
                    NumeroAlumnos = g.Count()
                })
                .ToList();

            return View(grupos);
        }

        public IActionResult Consulta10()
        {
            var grupos = Program.Alumnos
                .GroupBy(a => a.Curso.Ciclo)
                .Select(g => new CicloAgrupadoViewModel
                {
                    NombreCiclo = g.Key,
                    NumeroAlumnos = g.Count(),
                    Alumnos = g.Select(a => a.Nombre).OrderBy(n => n).ToList()
                })
                .ToList();

            return View(grupos);
        }
    }
}

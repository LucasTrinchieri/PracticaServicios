using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;

namespace Practica.Controllers
{
    public class AlumnoController : ApiController
    {
        List<AlumnoServicio> Alumnos = Escuela.Instancia.ObtenerLista()
                                       .Select(x => new AlumnoServicio
                                       (
                                            x.Id,
                                            x.Nombre
                                       )).ToList();

        public IHttpActionResult Get(string alumno = null)
        {
            List<AlumnoServicio> alumnosFiltrados = Alumnos;

            if (!string.IsNullOrEmpty(alumno))
            {
                alumnosFiltrados = Alumnos.Where(x => x.Nombre == alumno).ToList();
            }

            return Ok(alumnosFiltrados);
        }

        public IHttpActionResult Get(int id)
        {
            AlumnoServicio a = Alumnos.FirstOrDefault(x => x.Id == id);

            if (a == null)
            {
                return BadRequest();
            }
            return Ok(a);
        }

        public IHttpActionResult Post(AlumnoServicio a)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Alumno alumno = Escuela.Instancia.CrearAlumno(a.Nombre);

            AlumnoServicio alumnoServicio = new AlumnoServicio(alumno.Id, alumno.Nombre);

            return Created("", alumnoServicio);
        }

        public IHttpActionResult Put(int id, AlumnoServicio a)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            AlumnoServicio alumno = Alumnos.FirstOrDefault(x => x.Id == id);

            if (alumno == null)
            {
                return BadRequest();
            }

            alumno.Nombre = a.Nombre;

            return Ok(alumno);
        }

        public IHttpActionResult Delete(int id)
        {
            Alumno a = Escuela.Instancia.EliminarAlumno(id);

            if (a == null)
            {
                return BadRequest();
            }

            AlumnoServicio alumnoServicio = new AlumnoServicio(a.Id, a.Nombre);

            return Ok(alumnoServicio);
        }
    }

    public class AlumnoServicio
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " Nombre Obligatorio")]
        public string Nombre { get; set; }
        public List<MateriaServicio> Materias { get; set; }

        public AlumnoServicio()
        {

        }

        public AlumnoServicio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Materias = new List<MateriaServicio>()
            {
                new MateriaServicio(1, "Matematica"),
                new MateriaServicio(2, "Lengua"),
                new MateriaServicio(3, "Plastica"),
                new MateriaServicio(4, "Geografia")
            };
        }
    }
    public class MateriaServicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<NotasServicio> Notas { get; set; }

        public MateriaServicio()
        {

        }

        public MateriaServicio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Notas = new List<NotasServicio>()
            {
                new NotasServicio(4),
                new NotasServicio(7),
                new NotasServicio(10),
                new NotasServicio(2),
            };
        }
    }
    public class NotasServicio
    {
        public int Nota { get; set; }
        public bool Aprobado { get; set; }

        public NotasServicio()
        {

        }
        public NotasServicio(int nota)
        {
            Nota = nota;
            Aprobado = nota > 5;
        }
    }
}

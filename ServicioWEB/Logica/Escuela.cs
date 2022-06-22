using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Escuela
    {
        private static Escuela Logica = null;

        private Escuela() { }

        public static Escuela Instancia
        {
            get
            {
                if (Logica == null)
                    Logica = new Escuela();
                return Logica;
            }
        }

        static List<Alumno> Alumnos = new List<Alumno>()
        {
            new Alumno(1, "Lucas"),
            new Alumno(2, "Lucas"),
            new Alumno(3, "Matias"),
            new Alumno(4, "Julian"),
            new Alumno(5, "Fabian"),
        };

        public List<Alumno> ObtenerLista()
        {
            return Alumnos;
        }

        public Alumno ObtenerAlumno(int id)
        {
            return Alumnos.FirstOrDefault(x => x.Id == id);
        }

        public Alumno CrearAlumno(string nombre)
        {
            Alumno alumno = new Alumno(Alumnos.Last().Id + 1, nombre);

            Alumnos.Add(alumno);

            return alumno;
        }

        public Alumno EliminarAlumno(int id)
        {
            Alumno a = Alumnos.FirstOrDefault(x => x.Id == id);

            Alumnos = Alumnos.Where(x => x.Id != id).ToList();

            return a;
        }
    }
}

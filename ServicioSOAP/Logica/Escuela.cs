using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Escuela
    {
        private static Escuela instancia = null;

        private Escuela() { }

        public static Escuela Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Escuela();
                }

                return instancia;
            }
        }

        static List<Alumno> Alumnos = new List<Alumno>()
        {
            new Alumno(1, "Lucas"),
            new Alumno(2, "Lucas"),
            new Alumno(3, "Tortuga"),
            new Alumno(4, "Ibai"),
            new Alumno(5, "Locuras")
        };

        public List<Alumno> ObtenerLista()
        {
            return Alumnos;
        }

        public Alumno ObtenerAlumno(int id)
        {
            return Alumnos.FirstOrDefault(x => x.Id == id);
        }

        public Alumno Agregar(string nombre)
        {
            Alumno a = new Alumno(Alumnos.Last().Id + 1, nombre);

            Alumnos.Add(a);

            return a;
        }

        public Alumno Eliminar(int id)
        {
            Alumno a = Alumnos.FirstOrDefault(x => x.Id == id);

            Alumnos = Alumnos.Where(x => x.Id != id).ToList();

            return a;
        }

        public Alumno Modificar(int id, string nombre)
        {
            Alumno a = Alumnos.FirstOrDefault(x => x.Id == id);

            a.Modificar(nombre);

            return a;
        }
    }
}

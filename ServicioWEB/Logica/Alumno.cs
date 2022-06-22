using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Materia> Materias { get; set; }
        public DateTime Inscripcion { get; set; }
        public bool Graduado{ get; set; }

        public Alumno()
        {

        }

        public Alumno(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Inscripcion = DateTime.Now;
            Graduado = false;
            Materias = new List<Materia>()
            {
                new Materia(1, "Matematica"),
                new Materia(2, "Lengua"),
                new Materia(3, "Geografia"),
                new Materia(4, "Plastica"),
            };
        }

        public List<Materia> ObtenerMaterias()
        {
            return Materias;
        }
    }
}

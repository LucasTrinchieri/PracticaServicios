using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EnElPrograma { get; set; }
        public DateTime Adicion { get; set; }
        public DateTime Modificacion { get; set; }

        public Materia()
        {

        }

        public Materia(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            EnElPrograma = true;
            Adicion = DateTime.Now;
            Modificacion = DateTime.Now;
        }

        public void Modificar()
        {
            Modificacion = DateTime.Now;
        }
    }
}

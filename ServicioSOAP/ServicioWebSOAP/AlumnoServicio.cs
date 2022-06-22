using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWebSOAP
{
    [DataContract]
    public class AlumnoServicio
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
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
                new MateriaServicio(3, "Ingles"),
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Logica;

namespace ServicioWebSOAP
{
    public class Service1 : IService1
    {
        public List<AlumnoServicio> Alumnos = Escuela.Instancia.ObtenerLista()
                                              .Select( x => new AlumnoServicio
                                              (
                                                  x.Id,
                                                  x.Nombre
                                              )).ToList();

        public AlumnoServicio Agregar(string nombre)
        {
            Alumno a = Escuela.Instancia.Agregar(nombre);

            AlumnoServicio alumnoServicio = new AlumnoServicio(a.Id,a.Nombre);

            Alumnos.Add(alumnoServicio);

            return alumnoServicio;
        }

        public AlumnoServicio Eliminar(int id)
        {
            Alumno a = Escuela.Instancia.Eliminar(id);

            AlumnoServicio alumnoServicio = new AlumnoServicio(a.Id, a.Nombre);

            return alumnoServicio;
        }

        public AlumnoServicio Modificar(int id, string nombre)
        {
            throw new NotImplementedException();
        }

        public AlumnoServicio ObtenerAlumno(int id)
        {
            return Alumnos.FirstOrDefault( x => x.Id == id);
        }

        public List<AlumnoServicio> ObtenerLista()
        {
            return Alumnos;
        }
    }
}

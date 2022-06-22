using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWebSOAP
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<AlumnoServicio> ObtenerLista();
        [OperationContract]
        AlumnoServicio ObtenerAlumno(int id);
        [OperationContract]
        AlumnoServicio Agregar(string nombre);
        [OperationContract]
        AlumnoServicio Modificar(int id, string nombre);
        [OperationContract]
        AlumnoServicio Eliminar(int id);
    }
}

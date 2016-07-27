using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Hospital.SaoJose.Negocios;

namespace Hospital.SaoJose.RecursoService
{
    [ServiceContract]
    public interface IRecurso
    {
        [OperationContract]
        [WebGet]
        [WebInvoke]
        IEnumerable<Recurso> ListaTodos(string chaveAcesso);

        [OperationContract]
        [WebGet]
        [WebInvoke]
        Recurso ObterPorId(string chaveAcesso, int Id);
    }
}

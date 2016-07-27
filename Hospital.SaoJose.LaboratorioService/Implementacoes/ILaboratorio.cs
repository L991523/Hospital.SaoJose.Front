using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Hospital.SaoJose.Negocios;

namespace Hospital.SaoJose.LaboratorioService
{
    [ServiceContract]
    public interface ILaboratorio
    {
        [OperationContract]
        [WebGet]
        [WebInvoke]
        Exame BuscaResultadoExame(string cpfPaciente);

        [OperationContract]
        [WebGet]
        [WebInvoke]
        Laudo BuscaResultadoLaudo(string cpfPaciente);

        [OperationContract]
        [WebGet]
        [WebInvoke]
        List<Laudo> BuscaTodosLaudos();

        [OperationContract]
        [WebGet]
        [WebInvoke]
        List<Exame> BuscaTodosExames();
    }
}

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
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class RecursoService : IRecurso
    {
        private DBContext db = new DBContext();

        /// <summary>
        /// Busca a lista de todos os recursos disponíveis no sistema
        /// </summary>
        /// <param name="chaveAcesso">Chave para acesso ao método</param>
        public IEnumerable<Recurso> ListaTodos(string chaveAcesso)
        {
            return db.Recursos.ToList();
        }

        /// <summary>
        /// Busca um recurso de acordo com sua chave de identificação
        /// </summary>
        /// <param name="chaveAcesso">Chave para acesso ao método</param>
        /// <param name="Id">ID do recurso desejado</param>
        public Recurso ObterPorId(string chaveAcesso, int Id)
        {
            Recurso recursoPesquisado = db.Recursos.Find(Id);
            return recursoPesquisado;
        }
    }
}
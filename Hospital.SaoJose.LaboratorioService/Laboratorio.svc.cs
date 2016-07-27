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

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Laboratorio : ILaboratorio
    {
        private DBContext db = new DBContext();

        public Exame BuscaResultadoExame(string cpfPaciente)
        {

            // Verifica liberação de exames e laudos (CSU02)
            //1 - Para cada paciente, o sistema obtêm o seu CPF e verifica junto à interface dos laboratórios cadastrados, a liberação de laudos e exames;
            //2 - Se o laboratório retornar informações de novos resultados, o agente atualiza junto ao  ca-dastro do paciente os resultados;
            return new Exame();
        }

        public Laudo BuscaResultadoLaudo(string cpfPaciente)
        {
            // Verifica liberação de exames e laudos (CSU02)
            //1 - Para cada paciente, o sistema obtêm o seu CPF e verifica junto à interface dos laboratórios cadastrados, a liberação de laudos e exames;
            //2 - Se o laboratório retornar informações de novos resultados, o agente atualiza junto ao  ca-dastro do paciente os resultados;
            return new Laudo();
        }

        /// <summary>
        /// Retorna a lista de todos os laudos disponiveis no sistema
        /// </summary>
        /// <returns></returns>
        public List<Laudo> BuscaTodosLaudos()
        {
            return db.Laudos.ToList();
        }

        /// <summary>
        /// Retorna a lista de todos os exame disponiveis no sistema
        /// </summary>
        /// <returns></returns>
        public List<Exame> BuscaTodosExames()
        {
            return db.Exames.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.SaoJose.Negocios
{
    public class Laboratorio
    {

        /// Verifica liberação de exames e laudos(CSU02) 
        public void BuscaExamesLaudos()
        {
            Exame examePaciente;
            Laudo laudoPaciente;
            try
            {
                //1 - O sistema obtêm a relação de pacientes com exames e laudos pendentes;
                List<Paciente> listaPacientesPendentes = this.ObterListaPacientesComExamesLaudosPendentes();

                foreach(Paciente paciente in listaPacientesPendentes)
                {
                    //2 - Para cada paciente, o sistema obtêm o seu CPF e verifica junto à interface dos laboratórios cadastrados, a liberação de laudos e exames;
                    examePaciente = this.BuscaExamePaciente(paciente.Cpf);
                    laudoPaciente = this.BuscaLaudoPaciente(paciente.Cpf);

                    //3 - Se o laboratório retornar informações de novos resultados, o agente atualiza junto ao  ca-dastro do paciente os resultados;
                    this.AtualizaDadosPaciente(paciente, examePaciente, laudoPaciente);

                    //4 - O agente dispara um SMS para o médico/enfermeiro responsável pelo paciente, infor-mando sobre a liberação do resultado;
                    this.DisparaNotificaoResponsavel(new ProfissionalSaude());

                    //5 - O agente atualiza na relação de pacientes, a obtenção do exame/laudo e remove o usuário da lista de pendentes de verificação;
                    this.RemovePacienteListaPendentes(paciente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Implementacoes

        private List<Paciente> ObterListaPacientesComExamesLaudosPendentes()
        {
            try
            {
                List<Paciente> listaPacientes = new List<Paciente>();
                return listaPacientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Exame BuscaExamePaciente(string CpfPaciente)
        {
            try
            {
                return new Exame();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Laudo BuscaLaudoPaciente(string CpfPaciente)
        {
            try
            {
                return new Laudo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DisparaNotificaoResponsavel(ProfissionalSaude profissionalResponsavel)
        {
            try
            {
                profissionalResponsavel.DisparaNotificacao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AtualizaDadosPaciente(Paciente paciente, Exame exame, Laudo laudo)
        {
            try
            {
                paciente.AtualizaDadosPaciente(paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void RemovePacienteListaPendentes(Paciente paciente)
        {
            try
            {
                paciente.RemovePacienteListaPendentes(paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.SaoJose.Negocios
{
    public class Sensor
    {
        /// Realizar leitura dos sensores (CSU04)
        public void RealizaLeituraSensores()
        {
            try
            {
                // 1 - O agente realiza a leitura do barramento disponibilizado pelos equipamentos do hospital em busca de novas informações;
                List<Barramento> dadosBarramento = new List<Barramento>();

                foreach(Barramento itemBarramento in dadosBarramento)
                {
                    // 2 - A cada informação recuperada, o agente realiza o vinculo ao cadastro do paciente relacionado ao sensor que está sendo lido;
                    this.AtualizaDadosPaciente(itemBarramento.PacienteVinculado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Implementacoes

        private void AtualizaDadosPaciente(Paciente paciente)
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
        #endregion
    }
}

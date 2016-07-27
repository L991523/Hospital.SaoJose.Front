using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hospital.SaoJose.Negocios;

namespace Hospital.SaoJose.Agentes
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------
            Console.WriteLine(DateTime.Now.ToString() + " - Iniciando a execução do agente.");
            //--------------------------------------------------------------------------------

            //
            // Chama o metodo que ira realizar a leitura dos sensores
            //
            Console.WriteLine(DateTime.Now.ToString() + " - Iniciando a leitura dos sensores.");

            RealizaLeituraSensores();

            Console.WriteLine(DateTime.Now.ToString() + " - Finalizando a leitura dos sensores.");
            //--------------------------------------------------------------------------------

            //
            // Chama o metodo que ira realizar a verificação de liberação de exames e laudos
            //
            Console.WriteLine(DateTime.Now.ToString() + " - Iniciando a liberação de exames e laudos.");

            VerificaLiberacaoExamesLaudos();

            Console.WriteLine(DateTime.Now.ToString() + " - Finalizando a liberação de exames e laudos.");
            //--------------------------------------------------------------------------------

            //--------------------------------------------------------------------------------
            Console.WriteLine(DateTime.Now.ToString() + " - Finalizando a execução do agente.");
            //--------------------------------------------------------------------------------

            // Finalizando a execução do agente
            Environment.Exit(0);
        }

        #region Implementações

        /// <summary>
        /// Chama os objetos de negócio que implementam o caso de uso: Realizar leitura dos sensores (CSU04)  
        /// </summary>
        private static void RealizaLeituraSensores()
        {
            Sensor leituraSensores;

            try
            {
                leituraSensores = new Sensor();
                leituraSensores.RealizaLeituraSensores();
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString() + " - Ocorreu algum erro na realização da leitura dos sensores. Detalhes: " + ex.Message);
            }
        }

        /// <summary>
        /// Chama os objetos de negócio que implementam o caso de uso: Verifica liberação de exames e laudos (CSU02) 
        /// </summary>
        private static void VerificaLiberacaoExamesLaudos()
        {
            Laboratorio interfaceLaboratorio;

            try
            {
                interfaceLaboratorio = new Laboratorio();
                interfaceLaboratorio.BuscaExamesLaudos();
            } catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString() + " - Ocorreu algum erro na verificação de exames e laudos. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}

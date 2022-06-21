using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADS2022T
{
    /// <summary>
    /// Esta classe faz o tratamento das exceções e salva no arquivo excecoes.txt
    /// </summary>
    public class TratamentoExcecao
    {

        /// <summary>
        /// Obtém ou define o nome do arquivo de log de exceções
        /// </summary>
        public string FileName
        {
            get
            {
                return m_fileName;
            }

            set
            {
                m_fileName = value;
            }
        }
        private string m_fileName = "~/Excecoes.txt";




        /// <summary>
        /// Salva os dados da exceção no arquivo excecao.txt
        /// </summary>
        /// <param name="ex">Dados da exceção da classe Exception</param>
        public void SaveException(Exception ex)
        {


        string caminhoFisico = System.Web.HttpContext.Current.Server.MapPath(m_fileName);
        String conteudo = "Data: " + DateTime.Now.ToString() + "\n";
            conteudo += "Mensagem: " + ex.Message + "\n";
            conteudo += ex.GetType().ToString() + "\n";
            conteudo += ex.Message + "\n";
            conteudo += ex.StackTrace + "\n";
            conteudo += "----------------------------------\n";

            System.IO.File.AppendAllText(caminhoFisico, conteudo);
        }

        /// <summary>
        /// Recupera todas as ocorrencias no arquivo excecao.txt
        /// </summary>
        /// <returns></returns>
        public string LoadException()
        {
            string caminhoFisico = System.Web.HttpContext.Current.Server.MapPath(m_fileName);
            if (System.IO.File.Exists(caminhoFisico))
            {
                return System.IO.File.ReadAllText(caminhoFisico);
            }
            return "";
        }

        /// <summary>
        /// Exclui o arquivo
        /// </summary>
        public void ClearException()
        {
            string caminhoFisico = System.Web.HttpContext.Current.Server.MapPath(m_fileName);
            if (System.IO.File.Exists(caminhoFisico))
            {
                System.IO.File.WriteAllText(caminhoFisico, "");
            }

        }
    }
}

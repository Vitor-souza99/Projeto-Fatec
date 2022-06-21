using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADS2022T;

namespace Projeto4
{
    public partial class ExibirExcecoes : System.Web.UI.Page
    {
        /// <summary>
        /// Este método é excutado toda vez que a página for recarregada no navegador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TratamentoExcecao ex = new TratamentoExcecao();
            ex.FileName = "log.txt";
            Excecoes.Text = ex.LoadException().Replace("\n", "<br/>");

        }

        protected void LimparLog_Click(object sender, EventArgs e)
        {
            TratamentoExcecao ex = new TratamentoExcecao();
            ex.FileName = "log.txt";
            ex.ClearException();
            Excecoes.Text = "";
        }
    }
}
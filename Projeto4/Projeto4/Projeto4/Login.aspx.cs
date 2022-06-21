using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Entrar_Click(object sender, EventArgs e)
        {
            if (NomeAcesso.Text.Trim() == "")
            {
                Mensagem.Text = "Digite o nome de acesso.";
            }
            else if (Senha.Text.Trim() == "")
            {
                Mensagem.Text = "Digite sua senha.";
            }
            else
            {

                if (NomeAcesso.Text == "Admin" && Senha.Text == "12345")
                {
                    //cria uma variavel de controle para identificar se o usuario esta ou não autenticado.
                    Session["Autenticado"] = "Admin";

                    //1. inicializa a autenticação
                    System.Web.Security.FormsAuthentication.Initialize();

                    //2. criar o ticket de autenticação do usuário
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "Admin", DateTime.Now, DateTime.Now.AddMinutes(20), false, FormsAuthentication.FormsCookieName);

                    //3. Criptografa o ticket e registra no arquivo (cookie) no navegador
                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));

                    Response.Redirect(FormsAuthentication.GetRedirectUrl("Admin", false));
                }
                else
                {
                    Mensagem.Text = "Dados de acesso invalidos";
                }
            }
        }
    }
}
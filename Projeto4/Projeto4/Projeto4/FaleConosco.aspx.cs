using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//RELACIONADO A E-MAIL
using System.Net.Mail;
using ADS2022T;

namespace Projeto4
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                //1. VALIDAR OS DADOS DIGITADOS
                String mensagem = Mensagem.Text.Trim();
                String nome = Nome.Text.Trim();
                String email = Email.Text.Trim();

                if (mensagem == "")
                {
                    MsgLabel.Text = "Não é possivel enviar mensagem sem conteudo";
                }
                else if (nome == "")
                {
                    MsgLabel.Text = "É necessário informar o seu nome para que possamos entrar em contato";
                }
                else if (email == "")
                {
                    MsgLabel.Text = "Precisamos do seu e-mail para que possamos entrar em contato";
                }
                else
                {
                    //2. CRIA O PACOTE DO E-MAIL
                    //Criar uma instancia da classe MailMessage
                    MailMessage mail = new MailMessage();
                    mail.To.Add("contato@gseudominio.com");
                    mail.Subject = "Mensagem Enviada. Entraremos em contato em breve!";
                    MailAddress from = new MailAddress("contato@seudominio.com");
                    mail.From = from;
                    mail.Body = "Mensagem: " + mensagem + "\n";
                    mail.Body += "Nome: " + nome + "\n";
                    mail.Body += "E-mail: " + email + "\n";
                    mail.IsBodyHtml = false;

                    //3. ENVIA O E-MAIL
                    // Criar uma instancia da classe SmtpClient
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.seudominio.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("contato@seudominio.com", "suasenha");
                    smtp.Send(mail);

                    //limpa memória
                    mail.Dispose();
                    smtp.Dispose();
                }
            }
            catch (Exception ex)
            {
                MsgLabel.Text = "Falha ao enviar o e-mail" + ex.Message;

                TratamentoExcecao exx = new TratamentoExcecao();

                exx.FileName = "log.txt";
                exx.SaveException(ex);
            }

        }
    }
}
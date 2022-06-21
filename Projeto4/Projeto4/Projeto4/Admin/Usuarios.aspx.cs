using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppDatabase;

namespace Projeto4
{
    public partial class Usuarios : System.Web.UI.Page

    {

        string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/DBADST2022.accdb") + ";Persist Security Info=False;";

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (Nome.Text.Trim() == "")
            {
                Mensagem.Text = "Preencha os campo *NOME";
            }
            else if (NomeAcesso.Text.Trim() == "")
            {
                Mensagem.Text = "Preencha os campo *NOME ACESSO";
            }
            else if (Senha.Text.Trim() == "")
            {
                Mensagem.Text = "Preencha os campo *SENHA";
            }
            else
            {
                Mensagem.Text = "";
                string comando = "";

                if (PodeGrava(NomeAcesso.Text, Codigo.Text) == false)
                {
                    Mensagem.Text = "Este nome de acesso já está cadastrado para outro usuário";
                }
                else
                {
                    if (Codigo.Text.Trim() != "")
                    {
                        //EDIÇÃO
                        comando = "UPDATE Usuarios SET Nome='" + Utilities.Filter(Nome.Text) + "',NomeAcesso='" + Utilities.Filter(NomeAcesso.Text) + "',Senha='" + Utilities.Filter(Senha.Text) + "'WHERE Codigo=" + Utilities.Filter(Codigo.Text);
                    }
                    else
                    {
                        //INSERÇÃO
                        //2. String com comando SQL para inserir uma linha na tabela USUARIOS
                        comando = "INSERT INTO Usuarios(Nome,NomeAcesso,Senha) VALUES('" + Utilities.Filter(Nome.Text) + "','" + Utilities.Filter(NomeAcesso.Text) + "','" + Utilities.Filter(Senha.Text) + "');";
                    }
                    OleDBTransaction db = new OleDBTransaction();
                    db.ConnectionString = conexao;
                    db.Query(comando);

                    LimparControles();
                    LoadUsuarios();
                }

            }

        }

        protected void LoadUsuarios()
        {
            string comando = "SELECT Codigo,Nome,NomeAcesso FROM Usuarios ORDER BY Codigo ASC;";
            OleDBTransaction db = new OleDBTransaction();
            db.ConnectionString = conexao;
            System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);

            ExibirUsuarios.DataSource = tb;
            ExibirUsuarios.DataBind();
        }

        protected void LimparControles()
        {
            Codigo.Text = "";
            Nome.Text = "";
            NomeAcesso.Text = "";
            Senha.Text = "";
            Excluir.Visible = false;
        }

        protected void ExibirUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Codigo.Text = ExibirUsuarios.SelectedRow.Cells[1].Text;

            String comando = "SELECT * FROM Usuarios WHERE Codigo=" + Codigo.Text;

            OleDBTransaction db = new OleDBTransaction();
            db.ConnectionString = conexao;
            System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);

            Nome.Text = tb.Rows[0]["Nome"].ToString();
            NomeAcesso.Text = tb.Rows[0]["NomeAcesso"].ToString();
            Senha.Text = tb.Rows[0]["Senha"].ToString();
            Excluir.Visible = true;
        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            string comando = "DELETE from Usuarios WHERE Codigo=" + Codigo.Text;
            OleDBTransaction db = new OleDBTransaction();
            db.ConnectionString = conexao;
            db.Query(comando);
            LimparControles();
            LoadUsuarios();
            LimparControles();

        }

        protected bool PodeGrava(string nomeacesso, string cod)
        {
            //retorna true se o nome já existe para o novo usuário
            string comando = "SELECT * FROM Usuarios WHERE NomeAcesso='" + nomeacesso + "';";
            AppDatabase.OleDBTransaction db = new OleDBTransaction();
            db.ConnectionString = conexao;
            System.Data.DataTable tb = (System.Data.DataTable)db.Query(comando);
            if (tb.Rows.Count != 0)
            {
                if (tb.Rows[0]["Codigo"].ToString() == cod)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }


        }

    }
}
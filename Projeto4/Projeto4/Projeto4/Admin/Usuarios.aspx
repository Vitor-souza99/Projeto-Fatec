<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Projeto4.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-center">
        <div class="div-titulo">Cadastro</div>
    </div>

    <div class="row">
        <!-- FORMULARIO -->
        <div class="col-6">
            <div class="box margin-right">

                <asp:Label ID="Mensagem" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Codigo" runat="server" Font-Size="30px"></asp:Label>
                <br />

                <label>Nome</label>
                <asp:TextBox ID="Nome" MaxLength="255" runat="server"></asp:TextBox>
                <label>Login</label>
                <asp:TextBox ID="NomeAcesso" MaxLength="100" runat="server"></asp:TextBox>
                <label>Senha</label>
                <asp:TextBox ID="Senha" MaxLength="250" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Salvar" OnClick="Salvar_Click" runat="server" Text="Salvar" />
                <asp:Button ID="Excluir" runat="server" CssClass="botao-delete" Visible="false" OnClick="Excluir_Click" Text="Excluir Usuario" />
            </div>
        </div>

        <div class="box col-6">
            <br />
            <br />
            <asp:GridView AutoGenerateSelectButton="true" OnSelectedIndexChanged="ExibirUsuarios_SelectedIndexChanged" ID="ExibirUsuarios" CellPadding="8" BorderColor="#c0c0c0" Width="100%" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>

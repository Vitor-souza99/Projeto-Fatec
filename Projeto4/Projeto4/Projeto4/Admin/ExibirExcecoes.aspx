<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ExibirExcecoes.aspx.cs" Inherits="Projeto4.ExibirExcecoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-center">
        <div class="div-titulo">Log de exceções da aplicação</div>
    </div>
    <div>
        <asp:Label ID="Excecoes" runat="server"></asp:Label>
        <asp:Button ID="LimparLog" onClick="LimparLog_Click" runat="server" Text="Limpar log" />
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="Projeto4.FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row-center">
        <div class="div-titulo">Mande um e-mail para nós, vamos resolver seu problema!</div>
    </div>

    <div class="row-center">
        <!-- FORMULARIO -->
        <div class="col-6">
            <div class="box border">
                <asp:Label ID="MsgLabel" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <br />


                <label>MENSAGEM</label>
                <asp:TextBox ID="Mensagem" TextMode="MultiLine" Rows="6" MaxLength="256" runat="server"></asp:TextBox>
                <label>NOME</label>
                <asp:TextBox ID="Nome" MaxLength="100" runat="server"></asp:TextBox>
                <label>E-MAIL</label>
                <asp:TextBox ID="Email" MaxLength="250" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Enviar" OnClick="Enviar_Click" runat="server" Text="Enviar" />
            </div>
        </div>
        <div class="col-6">
            <div style="height:500px" class="box">
                <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d58875.07182238016!2d-47.350161!3d-22.739687!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana%20Ministro%20Ralph%20Biasi!5e0!3m2!1spt-BR!2sbr!4v1651598467305!5m2!1spt-BR!2sbr" width="100%" height="100%" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
            </div>
        </div>
    </div>
</asp:Content>

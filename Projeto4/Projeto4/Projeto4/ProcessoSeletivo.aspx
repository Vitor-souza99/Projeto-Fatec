<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="ProcessoSeletivo.aspx.cs" Inherits="Projeto4.ProcessoSeletivo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="div-titulo">Processo Seletivo</div>
    <h2 class="destaque">Processo Seletivo </h2>
    <h3 class="destaque">Inscrições</h3>
    <div class="link">
        <asp:HyperLink ID="Inscricao" NavigateUrl="https://urhsistemas.cps.sp.gov.br/dgsdad/selecaopublica/" runat="server">Clique aqui para se inscrever</asp:HyperLink>
    </div>
    <br />
    <br />
    <h3 class="destaque">Download de Material</h3>
    <div class="link">
        <a style="text-decoration: none;" href="MemorialCircunstanciado.doc">Roteiro para apresentação de memorial</a>
    </div>
    <br />
    <br />
    -> Candidatos a docente devem fazer o upload, no ato da inscrição, do seu memorial circunstanciado, 
    que é um currículo baseado na Plataforma Lattes do CNPq com comprovação de cada atividade.<br />
    <br />

    -> O Memorial Circunstanciado e documentação comprobatória deverão ser encaminhados em arquivo único, em formato PDF e com tamanho de, no máximo, 25 MB.
    <br />
    <br />
    <h2 class="destaque">Informações</h2>
    <h3 class="destaque">Assistência Técnica para Assuntos Docentes</h3>
    E-mail: atad@fatecsp.br
</asp:Content>

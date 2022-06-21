<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto4.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-30">
    </div>
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="Images/banner0.png" />
            </li>
            <li>
                <img src="Images/banner1.png" />
            </li>
            <li>
                <img src="Images/banner2.png" />
            </li>
            <li>
                <img src="Images/banner3.png" />
            </li>
            <li>
                <img src="Images/banner4.png" />
            </li>
        </ul>
    </div>

    <script>
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide",
                rtl: true
            });
        });
    </script>



    <div class="margin-top-30"></div>
    <div class="row" style="text-align: center">
        <div class="col-3">
            <div class="box border margin-right">
                <img width="100%" src="Images/si1.png" />
            </div>
        </div>

        <div class="col-3">
            <div class="box border margin-right">
                <img width="100%" src="Images/si2.jpg" />
            </div>
        </div>

        <div class="col-3">
            <div class="box border margin-right">
                <img width="100%" src="Images/si3.jpg" />
            </div>
        </div>

        <div class="col-3">
            <div class="box border margin-right">
                <img width="100%" src="Images/si4.jpg" />
            </div>
        </div>
    </div>

</asp:Content>

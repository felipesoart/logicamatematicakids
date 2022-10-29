<%@ Page Title="Multiplicação" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Multiplicacao.aspx.cs" Inherits="KidsLogicaMatematica.Multiplicacao" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron" style="background-image: linear-gradient(#ffe8cb, #ffffff)">
        <asp:HiddenField ID="quantidadeCalculos" runat="server" />
        <asp:HiddenField ID="erros" runat="server" />
        <asp:HiddenField ID="acertos" runat="server" />
        <asp:HiddenField ID="numeroImagem" runat="server" />
        <asp:HiddenField ID="numeroImagem2" runat="server" />
        <asp:HiddenField ID="valorIni" runat="server" />
        <asp:HiddenField ID="valorFim" runat="server" />
        <table>
            <tr>
                <td colspan="2">
                     <h3>Amiguinho existe uma regra antes de começarmos que é, <b>qualquer número multiplicado por 0 é igual a 0</b></h3>
                    <h1 id="calcula" runat="server"></h1>
                </td>
                <td rowspan="2" style="width: 400px">
                    <div style="text-align: center;">
                        <img id="imgVerificacao" runat="server" src="#" height="300" visible="false" style="padding-right: 25px" />
                        <h2 id="verificar" runat="server" visible="false" style="padding-right: 25px"></h2>
                    </div>

                </td>
            </tr>
            <tr>
                <td style="padding-right: 20px;">
                    <asp:Button ID="btnMenosImg" stylo="width: 270px;" runat="server" Text="Pirulito" CssClass="btn btn-default" OnClick="btnMenosImg_Click" />
                    <div class="panel-body">
                        <asp:Literal ID="ltImg" runat="server" />
                    </div>
                </td>
                <td>
                    <div class="form-group">
                        <label>Quantos pirulitos tem?</label>
                        <asp:TextBox ID="txtnumero" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnverificar" runat="server" Text="verificar" CssClass="btn btn-default" OnClick="btnverificar_Click" />
                </td>
            </tr>
        </table>

    </div>

</asp:Content>

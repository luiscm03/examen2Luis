<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen2LuisD.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
        Nombre:
        <asp:TextBox ID="tNombre" runat="server" OnTextChanged="tNombre_TextChanged"></asp:TextBox>
    </p>
    <p>
        Cedula:
        <asp:TextBox ID="TCedula" runat="server" OnTextChanged="TCedula_TextChanged"></asp:TextBox>
    </p>
    <p>
        Telefono:
        <asp:TextBox ID="tTelefono" runat="server" OnTextChanged="tTelefono_TextChanged"></asp:TextBox>
    </p>
    <p>
        Direccion:
        <asp:TextBox ID="tDireccion" runat="server" OnTextChanged="tDireccion_TextChanged"></asp:TextBox>
    </p>

    <div class="cent">

        <asp:ImageButton Class="button" ImageUrl="https://previews.123rf.com/images/mochipet/mochipet1707/mochipet170700056/82167896-ilustraci%C3%B3n-vectorial-bombilla-con-haces-de-luz-en-estilo-pop-art-dibujos-animados-con-contorno-aisl.jpg" runat="server" ID="bElectricidad" Height="90px" Width="212px" OnClick="bElectricidad_Click"/>
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="https://png.pngtree.com/png-vector/20210430/ourlarge/pngtree-cartoon-water-drops-png-image_3255250.png" runat="server" ID="bAgua" Height="90px" Width="212px" OnClick="bAgua_Click" />
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="https://previews.123rf.com/images/lineartestpilot/lineartestpilot1603/lineartestpilot160331677/54066387-cable-de-alimentaci%C3%B3n-a-mano-alzada-dibujo-animado-hecho.jpg" runat="server" ID="bCable" Height="90px" Width="212px" OnClick="bCable_Click"/>
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="https://w7.pngwing.com/pngs/873/954/png-transparent-telephone-cartoon-cartoon-phone-cartoon-character-comics-mobile-phone.png" runat="server" ID="bTelefono" Height="75px" Width="197px" OnClick="bTelefono_Click" />

    </div>
</asp:Content>

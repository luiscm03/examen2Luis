<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen2Luis
    .WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/estilos.css" rel="stylesheet" />
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

        <asp:ImageButton Class="button" ImageUrl="https://us.123rf.com/450wm/lineartestpilot/lineartestpilot1810/lineartestpilot181011266/110714792-bombilla-de-luz-el%C3%A9ctrica-doodle-de-dibujos-animados.jpg?ver=6" runat="server" ID="bElectricidad" Height="90px" Width="212px" OnClick="bElectricidad_Click"/>
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="https://png.pngtree.com/png-clipart/20210225/ourlarge/pngtree-cartoon-water-drops-png-image_2951979.jpg" runat="server" ID="bAgua" Height="90px" Width="212px" OnClick="bAgua_Click" />
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="https://previews.123rf.com/images/jemastock/jemastock1702/jemastock170211204/72706694-enchufe-de-conexi%C3%B3n-de-cable-de-ordenador-de-dibujos-animados.jpg" runat="server" ID="bCable" Height="90px" Width="212px" OnClick="bCable_Click"/>
&nbsp;&nbsp;
        <asp:ImageButton Class="button" ImageUrl="https://img.freepik.com/vector-premium/dibujos-animados-telefonos-inteligentes-tecnologia_24640-54524.jpg" runat="server" ID="bTelefono" Height="90px" Width="212px" OnClick="bTelefono_Click" />

    </div>
</asp:Content>

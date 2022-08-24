using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2LuisD
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lNombre.Text = Cliente.GetNombre();
            lCedula.Text=Cliente.GetCedula();
            lTelefono.Text=Cliente.GetTelefono();
            lDireccion.Text=Cliente.GetDireccion();

            lCodFactura.Text = Cliente.GetFactura().ToString();
            Cliente.codSer();
            lCodigoServ.Text = Convert.ToString(Cliente.GetTipoServ());
        }

        protected void bGuardar_Click(object sender, EventArgs e)
        {             
            if (Cliente.Guardar())
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : El usuario ha sido registrado con exito');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : El usuario no ha sido registrado, intente de nuevo');", true);
            }

        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {
            Cliente.SetMontoPagar(float.Parse(tMonto.Text));
            Cliente.SetDescuento(float.Parse(tDescuento.Text));

            Cliente.Calculo();
            lSubTotal.Text = Convert.ToString(Cliente.GetSubTotal());
            lIva.Text = Convert.ToString(Cliente.GetIVA());
            lTotal.Text = Convert.ToString(Cliente.GetTotal());
            lMonto.Text = Convert.ToString(Cliente.GetMontoPagar());
            lDescuento.Text = Convert.ToString(Cliente.GetDescuento());

        }

        protected void tMonto_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void tDescuento_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void bRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}
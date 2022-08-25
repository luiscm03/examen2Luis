using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2LuisDiegoC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void tNombre_TextChanged(object sender, EventArgs e)
        {
            Cliente.SetNombre(tNombre.Text);

        }

        protected void TCedula_TextChanged(object sender, EventArgs e)
        {
            Cliente.SetCedula(TCedula.Text);
        }

        protected void tTelefono_TextChanged(object sender, EventArgs e)
        {
            Cliente.SetTelefono(tTelefono.Text);
        }

        protected void tDireccion_TextChanged(object sender, EventArgs e)
        {
            Cliente.SetDireccion(tDireccion.Text);
        }

        protected void bElectricidad_Click(object sender, ImageClickEventArgs e)
        {
            int elect = 1;
            Cliente.SetServicio(elect);
            Cliente.SetFactura();
            Response.Redirect("DatosFinales.aspx");
        }

        protected void bAgua_Click(object sender, ImageClickEventArgs e)
        {
            int elect = 2;
            Cliente.SetServicio(elect);
            Cliente.SetFactura();
            Response.Redirect("DatosFinales.aspx");
        }

        protected void bCable_Click(object sender, ImageClickEventArgs e)
        {
            int elect = 3;
            Cliente.SetServicio(elect);
            Cliente.SetFactura();
            Response.Redirect("DatosFinales.aspx");
        }

        protected void bTelefono_Click(object sender, ImageClickEventArgs e)
        {
            int elect = 4;
            Cliente.SetServicio(elect);
            Cliente.SetFactura();
            Response.Redirect("DatosFinales.aspx");
        }
    }
}

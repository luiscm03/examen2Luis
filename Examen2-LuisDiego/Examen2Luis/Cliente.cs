using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen2Luis
{
    public class Cliente
    {
        private static string cedula { get; set; }
        private static string nombre { get; set; }
        private static string direccion { get; set; }
        private static string telefono { get; set; }

        private static float montoPagar { get; set; }
        private static float descuento { get; set; }
        private static float subTotal { get; set; }
        private static float iva { get; set; }
        private static float total { get; set; }

        private static int codigoFactura { get; set; }
        private static int codigoServicio;
        private static string tipoServicio;

        public Cliente(string nom, string ced, string direc, string telef, float montoPag, float desc, float subTo, float IVA, float tot)
        {
            nombre = nom;
            cedula = ced;
            direccion=direc;
            telefono = telef;
            montoPagar= montoPag;
            descuento = desc;
            subTotal = subTo;
            iva= IVA;
            total= tot;
            codigoFactura = 0;
        }

     

        public static string GetNombre() { return nombre; }
        public static string GetCedula() { return cedula; }
        public static string GetDireccion() { return direccion; }
        public static string GetTelefono() { return telefono; }
        public static float GetMontoPagar() { return montoPagar; }
        public static float GetDescuento() { return descuento; }
        public static float GetSubTotal() { return subTotal; }
        public static float GetIVA() { return iva; }
        public static float GetTotal() { return total; }

        public static int GetFactura() { return codigoFactura; }
        public static int GetServicio() { return codigoServicio; }
        public static string GetTipoServ() { return tipoServicio; }
        

        public static void SetCedula(string ced)
        {
            cedula = ced;
        }
        public static void SetNombre(string nom)
        {
            nombre = nom;
        }
        public static void SetDireccion(string dir)
        {
            direccion = dir;
        }
        public static void SetTelefono(string tell)
        {
            telefono = tell;
        }
        public static void SetMontoPagar(float montP)
        {
            montoPagar = montP;
        }
        public static void SetDescuento(float descc)
        {
            descuento = descc;
        }
        public static void SetSubTotal(float subTott)
        {
            subTotal = subTott;
        }
        public static void SetIVA(float iVA)
        {
            iva = iVA;
        }
        public static void SetTotal(float tott)
        {
            total = tott;
        }


        public static void SetFactura()
        {
            codigoFactura++;
        }
        public static void SetServicio(int codServ)
        {
            codigoServicio = codServ;
        }
        public static void SetTipoServ(string tServ)
        {
            tipoServicio = tServ;
        }

        //
        public static Boolean Salvar()
        {
            Boolean existe = false;
            //string strConnString = ConfigurationManager.ConnectionStrings["Examen2DBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Examen2DBConnectionString"].ConnectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Guardar_Info", con);
                command.Parameters.Add(new SqlParameter("@nombre", nombre));
                command.Parameters.Add(new SqlParameter("@cedula", cedula));
                command.Parameters.Add(new SqlParameter("@telefono", telefono));
                command.Parameters.Add(new SqlParameter("@direccion", direccion));
                command.Parameters.Add(new SqlParameter("@montoPagar", montoPagar));
                command.Parameters.Add(new SqlParameter("@descuento", descuento));
                command.Parameters.Add(new SqlParameter("@subTotal", subTotal));
                command.Parameters.Add(new SqlParameter("@iva", iva));
                command.Parameters.Add(new SqlParameter("@total", total));
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                existe = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                con.Close();
            }
            return existe;
        }

        public static void Calculo()
        {
            SetSubTotal(montoPagar - descuento);
            SetIVA((float)(GetSubTotal() * 0.13));
            SetTotal(GetSubTotal() + GetIVA());
        }

        public static void codSer()
        {
            if (codigoServicio == 1)
            {
                tipoServicio = "Electricidad";
            }
            else if (codigoServicio == 2)
            {
                tipoServicio = "Agua";
            }
            else if (codigoServicio==3)
            {
                tipoServicio = "Cable";
            }
            else if (codigoServicio==4)
            {
                tipoServicio = "Teléfono";
            }
        }
    }
}
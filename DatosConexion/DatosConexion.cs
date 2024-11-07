using System;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexion
    {
        public SqlConnection Conexion;
        public string CadenaConexion = "Server=DESKTOP-3PA9VUQ\\SQLEXPRESS=VideoClub;Trusted_Connection=True;TrustServerCertificate=TRUE;";

        public DatosConexion()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                    Conexion.Open();
            }
            catch (Exception)
            {
                throw new Exception("Error al tratar de abrir la conexion");
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                    Conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abm_peliculas
{
    public void AgregarPelicula(Pelicula pelicula)
    {
        using (SqlConnection conn = new ConexionBD().ObtenerConexion())
        {
            string query = "INSERT INTO Pelicula (Titulo, Precio, Anio, Duracion, IdGenero, IdCalificacion, IdSucursal) " +
                           "VALUES (@Titulo, @Precio, @Anio, @Duracion, @IdGenero, @IdCalificacion, @IdSucursal)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Titulo", pelicula.Titulo);
            cmd.Parameters.AddWithValue("@Precio", pelicula.Precio);
            cmd.Parameters.AddWithValue("@Anio", pelicula.Anio);
            cmd.Parameters.AddWithValue("@Duracion", pelicula.Duracion);
            cmd.Parameters.AddWithValue("@IdGenero", pelicula.IdGenero);
            cmd.Parameters.AddWithValue("@IdCalificacion", pelicula.IdCalificacion);
            cmd.Parameters.AddWithValue("@IdSucursal", pelicula.IdSucursal);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

}

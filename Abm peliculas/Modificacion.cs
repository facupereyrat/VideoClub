using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abm_peliculas
{
    public void ModificarPelicula(Pelicula pelicula)
    {
        using (SqlConnection conn = new ConexionBD().ObtenerConexion())
        {
            string query = "UPDATE Pelicula SET Titulo = @Titulo, Precio = @Precio, Anio = @Anio, Duracion = @Duracion, " +
                           "IdGenero = @IdGenero, IdCalificacion = @IdCalificacion, IdSucursal = @IdSucursal WHERE IdPelicula = @IdPelicula";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdPelicula", pelicula.IdPelicula);
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

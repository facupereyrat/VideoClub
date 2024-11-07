using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abm_peliculas
{
    public List<Pelicula> BuscarPeliculas(string criterio)
    {
        List<Pelicula> peliculas = new List<Pelicula>();

        using (SqlConnection conn = new ConexionBD().ObtenerConexion())
        {
            string query = "SELECT * FROM Pelicula WHERE Titulo LIKE @Criterio";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula
                {
                    IdPelicula = (int)reader["IdPelicula"],
                    Titulo = (string)reader["Titulo"],
                    Precio = (decimal)reader["Precio"],
                    Anio = (int)reader["Anio"],
                    Duracion = (int)reader["Duracion"],
                    IdGenero = (int)reader["IdGenero"],
                    IdCalificacion = (int)reader["IdCalificacion"],
                    IdSucursal = (int)reader["IdSucursal"]
                };
                peliculas.Add(pelicula);
            }
        }

        return peliculas;
    }

}

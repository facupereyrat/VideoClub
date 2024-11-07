using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PeliculaService
    {
        private readonly PeliculaRepository _peliculaRepository;

        // Constructor con inyección de dependencias
        public PeliculaService(PeliculaRepository peliculaRepository)
        {
            _peliculaRepository = peliculaRepository ?? throw new ArgumentNullException(nameof(peliculaRepository));
        }

        // Alta de película
        public void AltaPelicula(Pelicula pelicula)
        {
            if (pelicula == null) throw new ArgumentNullException(nameof(pelicula));

            // Validaciones simples
            if (string.IsNullOrEmpty(pelicula.Titulo)) throw new ArgumentException("El título es obligatorio.");
            if (pelicula.Precio <= 0) throw new ArgumentException("El precio debe ser mayor que cero.");
            if (pelicula.Anio <= 0 || pelicula.Anio > DateTime.Now.Year) throw new ArgumentException("Año inválido.");
            if (pelicula.Duracion <= 0) throw new ArgumentException("La duración debe ser mayor que cero.");

            try
            {
                _peliculaRepository.AltaPelicula(pelicula);
            }
            catch (SqlException ex)
            {
                // Log de excepción (idealmente con un logger, por ahora solo se muestra el mensaje)
                Console.WriteLine($"Error al insertar la película: {ex.Message}");
                throw;
            }
        }

        // Modificación de película
        public void ModificarPelicula(Pelicula pelicula)
        {
            if (pelicula == null) throw new ArgumentNullException(nameof(pelicula));

            // Validaciones simples
            if (string.IsNullOrEmpty(pelicula.Titulo)) throw new ArgumentException("El título es obligatorio.");
            if (pelicula.Precio <= 0) throw new ArgumentException("El precio debe ser mayor que cero.");
            if (pelicula.Anio <= 0 || pelicula.Anio > DateTime.Now.Year) throw new ArgumentException("Año inválido.");
            if (pelicula.Duracion <= 0) throw new ArgumentException("La duración debe ser mayor que cero.");

            try
            {
                _peliculaRepository.ModificarPelicula(pelicula);
            }
            catch (SqlException ex)
            {
                // Log de excepción (idealmente con un logger)
                Console.WriteLine($"Error al modificar la película: {ex.Message}");
                throw;
            }
        }

        // Eliminar película
        public void EliminarPelicula(int idPelicula)
        {
            if (idPelicula <= 0) throw new ArgumentException("El ID de la película no es válido.");

            try
            {
                _peliculaRepository.EliminarPelicula(idPelicula);
            }
            catch (SqlException ex)
            {
                // Log de excepción (idealmente con un logger)
                Console.WriteLine($"Error al eliminar la película: {ex.Message}");
                throw;
            }
        }

        // Obtener una película por su ID
        public Pelicula ObtenerPelicula
 

}

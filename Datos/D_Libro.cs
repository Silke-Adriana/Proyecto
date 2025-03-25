using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class D_Libro
    {
       private DB_Conexion conexion = new DB_Conexion();

         public DataTable Mostrar()
         {
              DataTable tabla = new DataTable();
              using (MySqlConnection connection = conexion.AbrirConexion())
              {
                  using (MySqlCommand query = new MySqlCommand("SELECT * FROM Libros", connection))
                  {
                     using (MySqlDataReader reader = query.ExecuteReader())
                     {
                         tabla.Load(reader);
                     }
                  }
              }
              return tabla;
         }
        public void Insertar(string titulo, string autor, string genero, string precio, string stock)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("INSERT INTO Libros (Titulo, Autor, Genero, Precio,Stock) VALUES (@titulo, @autor, @genero, @precio, @stock)", connection))
                {
                    query.Parameters.AddWithValue("@titulo", titulo);
                    query.Parameters.AddWithValue("@autor", autor);
                    query.Parameters.AddWithValue("@genero", genero);
                    query.Parameters.AddWithValue("@precio", precio);
                    query.Parameters.AddWithValue("@stock", stock);
                    query.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(int id_libro, string titulo, string autor, string genero, float precio, int stock)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("UPDATE Libros SET Titulo=@titulo, Autor=@autor, Genero=@genero, Precio=@precio,Stock=@stock  WHERE Id_libro=@id_libro", connection))
                {
                    query.Parameters.AddWithValue("@id_libro", id_libro);
                    query.Parameters.AddWithValue("@titulo", titulo);
                    query.Parameters.AddWithValue("@autor", autor);
                    query.Parameters.AddWithValue("@genero", genero);
                    query.Parameters.AddWithValue("@precio", precio);
                    query.Parameters.AddWithValue("@stock", stock);
                    query.ExecuteNonQuery();
                }
            }
        }

        public void ELiminar(int id_libro)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlCommand query = new MySqlCommand("DELETE FROM Libros WHERE id_libro=@id_libro", connection))
                {
                    query.Parameters.AddWithValue("@id_libro", id_libro);
                    query.ExecuteNonQuery();
                }
            }
        }
    }
}

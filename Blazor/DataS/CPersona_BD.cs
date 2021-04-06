using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Blazor.DataS
{
    public class CPersona_BD
    {
        private CConexion_BD conexion = new CConexion_BD();
        SqlDataReader lector;
        SqlCommand comando = new SqlCommand();

        public void Insertar(string cedula, string nombre, string apellido, string telefono, string correo, string fecha, string sangre, string provincia, string direccion, string latitud, string longitud, string covid, string justificacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertar_persona";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@sangre", sangre);
            comando.Parameters.AddWithValue("@provincia", provincia);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@latitud", latitud);
            comando.Parameters.AddWithValue("@longitud", longitud);
            comando.Parameters.AddWithValue("@covid", covid);
            comando.Parameters.AddWithValue("@justificacion", justificacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}

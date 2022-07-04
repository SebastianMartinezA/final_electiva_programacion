using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class IncidenteDatos
    {
        Conexion conexion;

        public IncidenteDatos()
        {
            this.conexion = new Conexion();
        }

        public int agregar(DateTime fecha, int idInfraccion, string patente)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Incidente]([Fecha],[idInfraccion],[Patente]) VALUES(@Fecha,@idInfraccion,@Patente); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;
            SqlComando.Parameters.Add("@idInfraccion", SqlDbType.Int).Value = idInfraccion;
            SqlComando.Parameters.Add("@Patente", SqlDbType.NVarChar).Value = patente;

            // Envia el parametro y este al completarlo devuelve el ID del elemento creado en la base de datos
            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public DataSet mostrarIncidentes()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM[dbo].[Incidente]");

            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(int id)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Incidente] WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}

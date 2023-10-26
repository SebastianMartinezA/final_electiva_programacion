using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class PagoDatos
    {
        Conexion conexion;

        public PagoDatos()
        {
            this.conexion = new Conexion();
        }

        public int agregar(DateTime fecha, int idIncidente, double monto)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Pago]([Fecha],[idIncidente],[Monto]) VALUES(@Fecha,@idIncidente,@Monto); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;
            SqlComando.Parameters.Add("@idIncidente", SqlDbType.Int).Value = idIncidente;
            SqlComando.Parameters.Add("@Monto", SqlDbType.Float).Value = (float)monto;

            // Envia el parametro y este al completarlo devuelve el ID del elemento creado en la base de datos
            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public DataSet mostrarPagos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM[dbo].[Pago]");

            return conexion.ejecutarSentencia(sentencia);
        }
    }
}

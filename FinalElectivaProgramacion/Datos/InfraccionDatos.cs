using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class InfraccionDatos
    {
        Conexion conexion;

        public InfraccionDatos()
        {
            this.conexion = new Conexion();
        }

        public int agregar(string desc, double importe, string tipo)
        {
            SqlCommand SqlComando = new SqlCommand("INSERT INTO [dbo].[Infraccion]([Descripcion],[Importe],[Tipo]) VALUES(@Descripcion,@Importe,@Tipo); SELECT SCOPE_IDENTITY()");

            SqlComando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = desc;
            SqlComando.Parameters.Add("@Importe", SqlDbType.Float).Value = (float)importe;
            SqlComando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = tipo.ToUpper();

            // Envia el parametro y este al completarlo devuelve el ID del elemento creado en la base de datos
            int modified = conexion.ejectutarComando(SqlComando);

            return modified;
        }

        public DataSet mostrarInfracciones()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM[dbo].[Infraccion]");

            return conexion.ejecutarSentencia(sentencia);
        }

        public int eliminar(int id)
        {
            SqlCommand SqlComando = new SqlCommand("DELETE FROM [dbo].[Infraccion] WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }

        public int modificar(int id, string desc, double importe)
        {
            SqlCommand SqlComando = new SqlCommand("UPDATE [dbo].[Infraccion] SET Descripcion=(@Descripcion), Importe=(@Importe) WHERE ID=(@Id)");

            SqlComando.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
            SqlComando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = desc;
            SqlComando.Parameters.Add("@Importe", SqlDbType.Float).Value = (float)importe;

            conexion.ejectutarComando(SqlComando);

            return 1;
        }
    }
}

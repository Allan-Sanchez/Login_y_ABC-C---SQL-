using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Registros_ABC__SQLServer
{
   public class BDComun
    {

        public static SqlConnection obtenerConexion() 
        {
            //@"Data source=DIEGO-THINK\SQLEXPRESS2012; Initial Catalog = prueba; Integrated Security = True"
            SqlConnection conn = new SqlConnection("server=DESKTOP-02FCSK2\\BASE_DATOS; database=Escuela ; integrated security = true");
            conn.Open();

            return conn;
           // conn.Close();
        }
    }
}

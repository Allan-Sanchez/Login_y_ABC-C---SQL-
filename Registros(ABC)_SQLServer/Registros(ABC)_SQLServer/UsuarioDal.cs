using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Registros_ABC__SQLServer
{
   public class UsuarioDal
    {

       public static int Crear_Cuenta(string nombre, string contrasena) 
       {

           int resultado = 0;

           SqlConnection conn = BDComun.obtenerConexion();

           SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Usuarios(nombre,contrasena) VALUES  ('{0}',PwdEncrypt('{1}'))", nombre, contrasena), conn);

           resultado = comando.ExecuteNonQuery();
           conn.Close();


           return resultado;
       
       
       }

       public static int Autentificar(string nombre, string contrasena) 
       {

           int resultado = -1;

           SqlConnection conn = BDComun.obtenerConexion();

           SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Usuarios WHERE  nombre ='{0}' and PwdCompare('{1}',contrasena)=1", nombre, contrasena), conn);

           SqlDataReader reader = comando.ExecuteReader();

           while (reader.Read())
           {
               resultado = 100;
           }
           conn.Close();

           return resultado;

       
       }










    }
}

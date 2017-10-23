using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace Registros_ABC__SQLServer
{
    public class AlumnoDal
    {

        public static int Agregar(Alumno alumnos) 
        {
            int retorno=0;
            using (SqlConnection conn = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format
                    ("Insert Into Alumnos(nombre,apellido,direccion,fecha_nacimiento)values('{0}','{1}','{2}','{3}')",

                    alumnos._nombre, alumnos._apellido, alumnos._direccion, alumnos._fecha_nacimiento), conn);

                retorno = comando.ExecuteNonQuery();
                conn.Close();
            }
            return retorno;
        
        }


        public static List<Alumno> Buscar_Alumno(string nombre, string apellido)
        {

            List<Alumno> Lista = new List<Alumno>();
            //realizamos la conexion 
            using (SqlConnection conn = BDComun.obtenerConexion())
            {
                //generamos un comando de SQL
                SqlCommand comando = new SqlCommand(string.Format("SELECT id,nombre,apellido,direccion,fecha_nacimiento FROM Alumnos  WHERE nombre LIKE  '%{0}%' AND apellido LIKE '%{1}%' ", nombre, apellido), conn);

                //funciona como el ejecutar del Gestor de la base de datos
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Alumno n_alumno = new Alumno();

                    n_alumno._id = reader.GetInt64(0);
                    n_alumno._nombre = reader.GetString(1);
                    n_alumno._apellido = reader.GetString(2);
                    n_alumno._direccion = reader.GetString(3);
                    n_alumno._fecha_nacimiento =  Convert.ToString(reader.GetDateTime(4));

                    Lista.Add(n_alumno);
                }
                conn.Close();

                return Lista;
            
            }
        
        }


        public static Alumno Obtener_Alumno(Int64 id)
        {

           
            //realizamos la conexion 
            using (SqlConnection conn = BDComun.obtenerConexion())
            {
                Alumno n_alumno = new Alumno();
                //generamos un comando de SQL
                SqlCommand comando = new SqlCommand(string.Format("SELECT id,nombre,apellido,direccion,fecha_nacimiento FROM Alumnos  WHERE id={0} ",id), conn);

                //funciona como el ejecutar del Gestor de la base de datos
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                   

                    n_alumno._id = reader.GetInt64(0);
                    n_alumno._nombre = reader.GetString(1);
                    n_alumno._apellido = reader.GetString(2);
                    n_alumno._direccion = reader.GetString(3);
                    n_alumno._fecha_nacimiento = Convert.ToString(reader.GetDateTime(4));

                    
                }
                conn.Close();

                return n_alumno;

            }

        }


        public static int Modifica(Alumno Alumnos) 
        {
            int retorno = 0;
        using (SqlConnection conn= BDComun.obtenerConexion())
        {
        //no puedo modificar la hora 
        SqlCommand comando = new SqlCommand(string.Format(
                                        "UPDATE Alumnos SET nombre ='{0}',apellido ='{1}', direccion ='{2}' WHERE id={3} ",
                                        Alumnos._nombre,Alumnos._apellido,Alumnos._direccion, Alumnos._id),conn);


        retorno = comando.ExecuteNonQuery();
        conn.Close();

        }


        return retorno;
        }


        public static int Eliminar(Int64 id) 
        {
            int retorno = 0;
            using (SqlConnection conn = BDComun.obtenerConexion()) 
            {

                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM Alumnos WHERE id={0}", id), conn);

                retorno = comando.ExecuteNonQuery();
                conn.Close();
            }

            return retorno;
        
        }

    }
}

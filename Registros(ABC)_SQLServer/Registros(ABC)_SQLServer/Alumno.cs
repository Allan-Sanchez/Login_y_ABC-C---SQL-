using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registros_ABC__SQLServer
{
   public class Alumno
    {
       public Int64 _id { get; set; }
       public string _nombre { get; set; }
       public string _apellido { get; set; }
       public string _direccion { get; set; }
       public string _fecha_nacimiento { get; set; }

       public Alumno()
       {

       }
       public Alumno(Int64 id,string nombre ,string apellido,string direccion, string fecha_nacimiento)
       {
           this._id = id;
           this._nombre = nombre;
           this._apellido = apellido;
           this._direccion = direccion;
           this._fecha_nacimiento = fecha_nacimiento;
       }
    

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea5_1.Clases
{
    public class Persona
    {

       private string nombre { set; get; }
        public string apellido { set; get; }
        public int edad { set; get; }
        public string direccion { set; get; }
        public string numTelefono { set; get; }
        public string numCelular { set; get; }
        public string email { set; get; }
        public DateTime fechanacimiento { set; get; }

        public Persona()
        {
            this.nombre = "JOSE";
        }

            public string getNombre()
            {
                return this.nombre;
            }
        public void setNombre(string p_nombre )
        {
            this.nombre = p_nombre;
        }

        }

        
        
    
}

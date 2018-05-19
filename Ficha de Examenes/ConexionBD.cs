using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; // Se agrega libreria de SQL, 
//colección de clases que se utiliza para obtener acceso a una base de datos de SQL Server en el espacio administrado.

namespace Ficha_de_Examenes
{
    public class ConexionBD // Clase creada para la conexion
    {       
        public void ObtenerConexion()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            //Conexion BD
            con.ConnectionString = @"Data Source=LENOVO;Initial Catalog=Buena_Salud;User ID=sa; Password=superuser";
            //con.Open(); //Abrimos la coneccion            

        }
    }
}

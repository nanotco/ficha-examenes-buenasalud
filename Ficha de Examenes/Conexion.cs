using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Ficha_de_Examenes
{
    class Conexion
    {
        private string cadena = "Data source=LENOVO; Initial Catalog=Buena_Salud; User Id=sa; Password=superuser";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
    }
        private void conectar();
    {
        cn = new SqlConnection(cadena);
    }

    public Conexion()
{
    conectar();
}
    public void consultar(string sql, string tabla)
{
    ds.Tables.Clear();
    da = new SqlDataAdapter(sql, cn);
    cmb = new SqlCommandBuilder (da);
    da.Fill (ds, tabla);
    
}
public bool eliminar (string tabla , string condicion)
{
cn.Open();
string sql = "delete from " + tabla + "where" + condicion;
comando = new SqlCommand (sql, cn);
int i = Comando.ExecuteNonQuery();
cn.Close();

if (if>0)
{
return true;
}
else 
{
return false;
}

public bool actualizar(string tabla, string campos, string condicion)
{
cn.Open();
string sql= "update " + tabla " set " + campos + "where " + condicion;
 int i = Comando.ExecuteNonQuery();
cn.Close(),
if (if>0)
{
return true;
}
else 
{
return false;
}
}
public DataTable consultar2(string tabla)
{
string sql = "select * from " + tabla ;
da = new sqlDataAdapter (sql, cn);
DataSet dts = new DataSet();
da.Fill (dts, tabla);
}



}




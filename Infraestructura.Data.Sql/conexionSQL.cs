using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//para usar sql
using System.Data.SqlClient;


namespace Infraestructura.Data.Sql
{
    public class conexionSQL
    {
        //instancio la conexion
        SqlConnection cn = new SqlConnection("server=.;Database=Negocios2017;uid=sa;pwd=sql");

        //propiedad solo lectura que retorna la conexion
        public SqlConnection CN {
            get { return cn; }

        }

    }
}

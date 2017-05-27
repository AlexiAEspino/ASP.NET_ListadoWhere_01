using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//hacer referencia de dominio entidades y de infraestructuradatasql
using System.Data;
using Infraestructura.Data.Sql;
using Dominio.Entidades;

namespace Dominio.Repositorio
{
    public class cliente_BL
    {

        /*****defino el metodo  a ejecutar  el metodo  listado*/
        public List<tb_Clientes> listado() {

            //instancia clase clienteDAL de infraesrutura data
            clienteDAL cliente = new clienteDAL();
            return cliente.listado();
        }
        /****************************************************/

        /*DEFINO METODO PARA AGREGAR CLIENTES*/
        public string Agregar(tb_Clientes reg) {
            clienteDAL cliente = new clienteDAL();

            return cliente.Agregar(reg);
        }


    }
}

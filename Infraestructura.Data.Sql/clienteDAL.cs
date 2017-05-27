using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//importar despues de hacer la referencia de dominio
using System.Data.SqlClient;
using System.Data;
using Dominio.Entidades;

namespace Infraestructura.Data.Sql
{
    public class clienteDAL
    {
        //instanciar la conecion
        conexionSQL conecta = new conexionSQL();


        /********Implementar un listado de clientes***********/

        public List<tb_Clientes> listado() {
            //instancio la lista a usar
            List<tb_Clientes> lista = new List<tb_Clientes>();
            
            //realizo la consulta
            SqlCommand cmd = new SqlCommand("select * from tb_clientes",conecta.CN);

            //abro la conexion
            conecta.CN.Open();

            //ejecuta la consulta
            SqlDataReader dr = cmd.ExecuteReader();
            //bucle para capturar los datos
            while (dr.Read()) {
                //instancio tipo entidad
                tb_Clientes reg = new tb_Clientes();
                //lleno de datos a los atributos de la entidad
                reg.idcliente = dr.GetString(0);
                reg.nombrecia = dr.GetString(1);
                reg.direccion = dr.GetString(2);
                reg.idpais = dr.GetString(3);
                reg.telefono = dr.GetString(4);
                //lleno la lista con la entidad
                lista.Add(reg);

            }
            //cierro el DataReader
            dr.Close();
            //cierro la conexion
            conecta.CN.Close();

            //retorno la lista
            return lista;
        }

        /************************************************/

        public string Agregar(tb_Clientes reg) {
            string msg = "";
            conecta.CN.Open();
            try {

                SqlCommand cmd = new SqlCommand("insert into tb_clientes values(@cod,@nom,@dir,@pais,@tele)",conecta.CN);

                cmd.Parameters.AddWithValue("@cod",reg.idcliente);
                cmd.Parameters.AddWithValue("@nom",reg.nombrecia);
                cmd.Parameters.AddWithValue("@dir",reg.direccion);
                cmd.Parameters.AddWithValue("@pais",reg.idpais);
                cmd.Parameters.AddWithValue("@tele",reg.telefono);

                cmd.ExecuteNonQuery();
                msg = "Registro Exitoso";

            }
            catch (SqlException e) {
                msg = e.Message;

            }
            finally {

                conecta.CN.Close();
            }


            return msg;
        }

    }
}

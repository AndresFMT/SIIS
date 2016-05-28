using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataInventory
{
     public class Data_Usuario
    {
        public string strconn = @"Data Source=FELIPEPC;Initial Catalog=BDInventario;Integrated Security=True";

        public Data_Usuario() { }
        public int ValidarUsuario(string Usuario,string Contraseña,int error)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrdenSql = new SqlCommand("SpValidarusuario",cnx);
                OrdenSql.CommandType = CommandType.StoredProcedure;

                try
                {
                    OrdenSql.Parameters.AddWithValue("@Id", Usuario);
                    OrdenSql.Parameters.AddWithValue("@Contraseña", Contraseña);
                    OrdenSql.Parameters.AddWithValue("@error",error).Direction = ParameterDirection.Output;
                    return OrdenSql.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSql.Dispose();
               
                }
            }
        }


    }
}

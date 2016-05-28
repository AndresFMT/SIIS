using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Inventory_Bussines
{
   public class Inventory_Bussines_Usuario
    {
        DataInventory.Data_Usuario Dl = new DataInventory.Data_Usuario();

        public int ValidarUsuario(string Usuario,string Contraseña,int error)
        {
            try
            {
                return Dl.ValidarUsuario(Usuario,Contraseña,error);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Dl = null;
            }
        }
    }
}

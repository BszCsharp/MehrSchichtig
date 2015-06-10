using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KundenDataAccess
{
    public class DTO
    {
        OleDbConnection con = null;

        private Boolean openConnection()
        {
            Boolean result = true;

            return result;
        }
    }  
}

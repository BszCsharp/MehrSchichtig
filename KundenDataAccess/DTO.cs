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
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\laptop_siemens\c#_public\KundenManage_ado\KundenDataAccess\kunden.mdb");
            try 
	        {	        
		        con.Open();
	        }
	        catch (OleDbException )
	        {
		
		       result = false;
	        }
            return result;
        }
    }  
}

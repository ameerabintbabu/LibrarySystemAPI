using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Book.ModelRepository
{
    public class BookRepository
    {

        public DataSet GetAllParentCategory(out int Status)
        {
            DataTable dt = new DataTable();
          
            try
            {
                SqlConnection conn = null;
                SqlDataReader rdr = null;
                conn = new SqlConnection("Server=(localdb)/MSSQLLocalDB;DataBase=LibrarySystemDB;Integrated Security=SSPI");
                conn.Open();
                SqlCommand cmd = new SqlCommand("CustOrderHist", conn);
                
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        //cmd.Parameters.Add("@CommandType",
                        //SqlDbType.VarChar, 50).Value = "GetAllContactType";
                       
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        
                        DataSet ds = new DataSet();
                    
                      
                        da.Fill(ds);

                Status = 1;
                return ds;
                 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dt != null)
                {
                    dt.Dispose();
                }
               
            }
        }
    }
}

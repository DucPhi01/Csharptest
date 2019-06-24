using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPresentation
{
    class MyConnection
    {
        public static SqlDataAdapter da;
        /// <summary>
        /// Fill Dataset with the data in database
        /// </summary>
        /// <param name="SvDataset"></param>
        /// <param name="ConnString"></param>
        /// <param name="query"></param>
        public void fillDataSet(DataSet SvDataset,String ConnString,String query)
        {
            // make connection
            try
            {
                SqlConnection conn = new SqlConnection(ConnString);
               da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder invBuilder = new SqlCommandBuilder(da);
                da.Fill(SvDataset, "dbo.KHOA");
                
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}

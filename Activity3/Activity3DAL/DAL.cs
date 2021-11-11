using Activity3DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3DAL
{
    public class DAL
    {
        //Reference Variable : Class Level : Member Variables
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        SqlDataReader sqlDataReaderObj;
        public DAL()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();

        }

        public List<ProductDTO> CheckProductName(ProductDTO p)
        {
            try
            {
                sqlConObj.ConnectionString = ConfigurationManager.
                   ConnectionStrings["AdvWorksDBConnStr"].ConnectionString;
                //ProductDTO p = new ProductDTO();
                
           
                sqlConObj.Open();
                string query = $"SELECT NAME FROM PRODUCTION.PRODUCT WHERE NAME LIKE '{p.check}%'";
                SqlCommand cmd = new SqlCommand(query, sqlConObj);
                
                List<ProductDTO> lstPro = new List<ProductDTO>();

                ProductDTO newepartObj = new ProductDTO();

                sqlDataReaderObj = cmd.ExecuteReader();
                while (sqlDataReaderObj.Read())
                {


                    lstPro.Add(new ProductDTO()
                    {
                        
                        ProductName = sqlDataReaderObj[0].ToString(),
                        

                    });

                }
                return lstPro;

            }
            catch (Exception e) { throw e; }
        }



    }
}

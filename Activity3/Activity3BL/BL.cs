using Activity3DAL;
using Activity3DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3BL
{
    public class BL
    {
        
        public List<ProductDTO> GetProductName(ProductDTO p)
        {
            try
            {
                DAL dalObj = new DAL();
                List<ProductDTO> results = dalObj.CheckProductName(p);
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}



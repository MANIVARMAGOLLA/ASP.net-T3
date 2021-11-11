using Activity3BL;
using Activity3DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Activity3API.Controllers
{
    public class Activity3Controller : ApiController
    {
        
        [HttpGet]
        public HttpResponseMessage GetProductDetailsByPrice(string id)
        {
            try
            {
               
                ProductDTO dto = new ProductDTO();
                
                 dto.check =id;

                BL blObj = new BL();

                var result = blObj.GetProductName(dto);
                if (result != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK,result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "No Data Exists");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

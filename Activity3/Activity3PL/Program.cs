using Activity3BL;
using Activity3DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3PL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Letter to search");
                string s = Console.ReadLine();


                BL blObj = new BL();
                ProductDTO dto = new ProductDTO();
                dto.check = s;

                List<ProductDTO> lstFinalResult = blObj.GetProductName(dto);
                foreach (var pro in lstFinalResult)
                {
                    Console.WriteLine(pro.ProductName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Our developers are working on it.Please quote the error message before when you contact customer care");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

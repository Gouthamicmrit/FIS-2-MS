using CustomerMicroServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BFFWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BFFCustController : ControllerBase
    {
        [HttpGet("GetAllCustomers")]

        public async Task<List<CustomerDTO>> GetAllCustomers()
        {
            return await GetAllCustomersInternal();
        }

        private async Task<List<CustomerDTO>> GetAllCustomersInternal()
        {
            string burl = "http://localhost:1274/api/";
            string url = burl + "Customer/GetAllCustomers";

            using(HttpClient client = new HttpClient())
            {
                List<CustomerDTO> custdto = new List<CustomerDTO>();
                using(HttpResponseMessage response =await client.GetAsync(url))
                {
                    using(HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        var customers = JsonConvert.DeserializeObject<List<CustomerDTO>>(data);

                        return customers;
                      
                    }
                }
            }
                               
        }
    }
}

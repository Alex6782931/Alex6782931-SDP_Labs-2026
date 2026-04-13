using Microsoft.AspNetCore.Mvc;
using System.Data;
using DatabaseAccessController;
using Newtonsoft.Json;

namespace SDP_WebAPI.Controllers
{




    [Route("api/[controller]")]
    public class SimpleGetAPIController : Controller
    {
        [HttpGet("SimpleGetMethod")]
        public String Get()
        {
            return $"This is returned b the web API server. Current time is:{DateTime.Now}";
        }

        private readonly IConfiguration _configuration;

        public SimpleGetAPIController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetCustomerData")]
        public String GetCustomerData()
        {
            dboGetCompanyData dboGetCompanyData = new dboGetCompanyData(_configuration["ConnectionStrings"]);
            DataTable dtResult = dboGetCompanyData.GetAllCustomerData();

            // Convert DataTable to JSON string
            string jsonString = JsonConvert.SerializeObject(dtResult);

            // Return JSON string
            return jsonString;
        }
        //Find Customer data
        [HttpGet("FindCustomerData")]
        public String FindCustomerData(int customerId)
        {
            dboGetCompanyData dboGetCompanyData = new dboGetCompanyData(_configuration["ConnectionStrings"]);
            DataTable dtResult = dboGetCompanyData.GetCustomerDataById(customerId);

            // Convert DataTable to JSON string
            string jsonString = JsonConvert.SerializeObject(dtResult);

            // Return JSON string
            return jsonString;
        }
    }
    
}
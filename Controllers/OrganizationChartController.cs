using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Julio.Francisco.De.Iriarte.Controllers
{
    [ApiVersion( "1.0" )]
    [Route( "api/v{version:apiVersion}/[controller]" )]
    [Authorize]
    public class OrganizationChartController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            try 
            {
                var someObject = new { Id = 1, Name = "Jorge" };
                return Json(someObject);
                /*return 
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(
                            content: JsonConvert.SerializeObject(someObject), 
                            encoding: Encoding.UTF8,
                            mediaType: "application/json"),
                        StatusCode = HttpStatusCode.OK,
                    };*/
            }
            catch
            {
                throw;
                /*return 
                    new HttpResponseMessage()
                    {
                        Content = new StringContent(""),
                        StatusCode = HttpStatusCode.OK
                    };
                    */
            }
        }
    }
}
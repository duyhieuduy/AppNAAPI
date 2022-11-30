using AppNAAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppNAAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        private readonly AppNauAnContext dbcontext;
        public UpdateController(AppNauAnContext context)
        {
            dbcontext = context;
        }
    }
}

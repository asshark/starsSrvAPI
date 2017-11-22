using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using starsSrvAPI.Models;
using System.Linq;

namespace starsSrvAPI.Controllers
{
    [Route("api/[controller]")]
    public class StarController : Controller
    {
        public StarController()
        {
        }

        [HttpGet]
public IEnumerable<Star> GetAll()
{
    return null;
}
    }
}
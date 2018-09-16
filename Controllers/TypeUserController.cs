using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApiEfCodeFirst.Models.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiEfCodeFirst.Controllers
{
    [Produces("application/json")]
    [Route("api/TypeUser")]
    public class TypeUserController : Controller
    {

        [HttpGet]
        public IActionResult Get(int id) {

            var svc = new UserTypeService();

            if (id < 0) {
                return BadRequest();
            }

            var result = svc.Get(id);

            if(result == null) {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
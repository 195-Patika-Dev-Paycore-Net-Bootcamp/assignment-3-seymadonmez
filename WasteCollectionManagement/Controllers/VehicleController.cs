using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WasteCollectionManagement.Context;
using WasteCollectionManagement.Models;

namespace WasteCollectionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IMapperSession _session;
        public VehicleController(IMapperSession session)
        {
            _session = session;
        }

        [HttpGet]
        public List<Vehicle> Get()
        {
            List<Vehicle> result = _session.Vehicles.ToList();
            return result;
        }


        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            Vehicle result = _session.Vehicles.Where(x => x.VehicleId == id).FirstOrDefault();
            return result;
        }

        [HttpPost]
        public void Post([FromBody] Vehicle vehicle)
        {

        }

        [HttpPut]
        public ActionResult<Vehicle> Put([FromBody] Vehicle request)
        {

            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult<Vehicle> Delete(int id)
        {

            return Ok();
        }


    }
}

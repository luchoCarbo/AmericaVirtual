using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayerAPI.Services.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {


        public readonly ITemperatureService _temperatureService;

        public TemperatureController(ITemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetTemperatures() 
        {
            var temperatureList = await _temperatureService.GetTemperatureList();

            return Ok(temperatureList);
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetTemperatureById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var temperatureSelected = await _temperatureService.GetTemperatureById(id);

            if (temperatureSelected == null)
            {
                return BadRequest();
            }

            return Ok(temperatureSelected);
        }

        [HttpPost]
        public IActionResult InsertTemperatureRecord([FromBody] Temperature temperature)
        {
            _temperatureService.InsertTemperatureRecord(temperature);
            return Ok();
        }
    }
}

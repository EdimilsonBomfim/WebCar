using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using WebCar.Domain.Entity;
using WebCar.Service.Interface;

namespace WebCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return Ok(_carService.List());
        }

        [HttpGet("{marca}")]
        public ActionResult<IEnumerable<Car>> Get(string marca)
        {
            return Ok(_carService.ListarPorMarca(marca));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] Car car)
        {

            if(ModelState.IsValid)
            {
                var result = _carService.Insert(car);
                if (result == false)
                {
                    return BadRequest("Erro - Cadastro não Realizado");

                }
            }
            else
            {
                return BadRequest(ModelState);
            }
            return Created("cadastro realizado com sucesso", car);
        }


    }
}
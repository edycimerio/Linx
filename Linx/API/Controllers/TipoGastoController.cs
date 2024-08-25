using API.Validadores;
using Domain.Dtos;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace API.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]

    public class TipoGastoController : ControllerBase
    {
        private readonly ITipoGastoService _service;
        public TipoGastoController(ITipoGastoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.ListTipoGastos();
            if (result.Count() > 0)
            {
                TipoGastoDto cat = new TipoGastoDto();
                cat.Codigo = 0;
                cat.NomeGasto = "...";
                result.Add(cat);
            }

            return Ok(result.OrderBy(x => x.Codigo));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.Consultar(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TipoGastoDto tipo)
        {
            await _service.Create(tipo);

            return Ok();
        }
    }
}

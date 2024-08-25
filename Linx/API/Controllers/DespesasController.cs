using API.Validadores;
using Domain.Dtos;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DespesasController : ControllerBase
    {
        private readonly IDespesaService _service;
        public DespesasController(IDespesaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.ListDespesas();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.Consultar(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DespesaDto despesa)
        {
            PostDespesaValidator validator = new PostDespesaValidator();

            ValidationResult results = validator.Validate(despesa);

            if (!results.IsValid)
            {
                return BadRequest(results.Errors);
            }

            await _service.Create(despesa);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(DespesaDto despesa)
        {
            PutDespesaValidator validator = new PutDespesaValidator();

            ValidationResult results = validator.Validate(despesa);

            if (!results.IsValid)
            {
                return BadRequest(results.Errors);
            }

            await _service.Edit(despesa);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id == 0)
                return BadRequest("Objeto dto está vazio!");

            await _service.Delete(id);

            return Ok();
        }
    }
}

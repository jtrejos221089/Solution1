using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace API.Controllers
{
    public class PacientesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public PacientesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Paciente>>> Get()
        {
            var paciente = await _unitOfWork.Pacientes.GetAllAsync();
            return Ok(paciente);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            var paciente = await _unitOfWork.Pacientes.GetByIdAsync(id);
            return Ok(paciente);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Paciente>> Post(Paciente paciente)
        {
            _unitOfWork.Pacientes.Add(paciente);
            _unitOfWork.Save();
            if (paciente == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = paciente.Id }, paciente);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Paciente>> Put(int id, [FromBody] Paciente paciente)
        {
            if (paciente == null)
                return NotFound();

            _unitOfWork.Pacientes.Update(paciente);
            _unitOfWork.Save();

            return paciente;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var paciente = await _unitOfWork.Pacientes.GetByIdAsync(id);

            if (paciente == null)
                return NotFound();

            _unitOfWork.Pacientes.Remove(paciente);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
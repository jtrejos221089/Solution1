using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace API.Controllers
{
    public class CentroMedicoController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CentroMedicoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CentroMedico>>> Get()
        {
            var centroMedico = await _unitOfWork.CentrosMedicos.GetAllAsync();
            return Ok(centroMedico);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            var centroMedico = await _unitOfWork.CentrosMedicos.GetByIdAsync(id);
            return Ok(centroMedico);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<CentroMedico>> Post(CentroMedico centroMedico)
        {
            _unitOfWork.CentrosMedicos.Add(centroMedico);
            _unitOfWork.Save();
            if (centroMedico == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = centroMedico.Id }, centroMedico);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CentroMedico>> Put(int id, [FromBody] CentroMedico centroMedico)
        {
            if (centroMedico == null)
                return NotFound();

            _unitOfWork.CentrosMedicos.Update(centroMedico);
            _unitOfWork.Save();

            return centroMedico;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete (int id)
        {
            var centroMedico = await _unitOfWork.CentrosMedicos.GetByIdAsync(id);

            if (centroMedico==null)
                return NotFound();

            _unitOfWork.CentrosMedicos.Remove(centroMedico);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}

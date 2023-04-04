using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace API.Controllers
{
    public class ProfesionalController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfesionalController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Profesional>>> Get()
        {
            var profesional = await _unitOfWork.Professionales.GetAllAsync();
            return Ok(profesional);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            var profesional = await _unitOfWork.Professionales.GetByIdAsync(id);
            return Ok(profesional);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Profesional>> Post(Profesional profesional)
        {
            _unitOfWork.Professionales.Add(profesional);
            _unitOfWork.Save();
            if (profesional == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = profesional.Id }, profesional);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Profesional>> Put(int id, [FromBody] Profesional profesional)
        {
            if (profesional == null)
                return NotFound();

            _unitOfWork.Professionales.Update(profesional);
            _unitOfWork.Save();

            return profesional;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var profesional = await _unitOfWork.Professionales.GetByIdAsync(id);

            if (profesional == null)
                return NotFound();

            _unitOfWork.Professionales.Remove(profesional);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
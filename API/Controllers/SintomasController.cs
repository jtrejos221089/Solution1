using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace API.Controllers
{
    public class SintomasController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public SintomasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Sintomas>>> Get()
        {
            var sintomas = await _unitOfWork.Sintomas.GetAllAsync();
            return Ok(sintomas);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            var sintomas = await _unitOfWork.Sintomas.GetByIdAsync(id);
            return Ok(sintomas);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Sintomas>> Post(Sintomas sintomas)
        {
            _unitOfWork.Sintomas.Add(sintomas);
            _unitOfWork.Save();
            if (sintomas == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = sintomas.Id }, sintomas);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Sintomas>> Put(int id, [FromBody] Sintomas sintomas)
        {
            if (sintomas == null)
                return NotFound();

            _unitOfWork.Sintomas.Update(sintomas);
            _unitOfWork.Save();

            return sintomas;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var sintomas = await _unitOfWork.Sintomas.GetByIdAsync(id);

            if (sintomas == null)
                return NotFound();

            _unitOfWork.Sintomas.Remove(sintomas);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
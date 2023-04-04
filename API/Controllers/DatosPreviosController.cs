using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace API.Controllers
{
    public class DatosPreviosController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public DatosPreviosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DatosPrevios>>> Get()
        {
            var datosPrevios = await _unitOfWork.DatosPrevios.GetAllAsync();
            return Ok(datosPrevios);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            var datosPrevios = await _unitOfWork.DatosPrevios.GetByIdAsync(id);
            return Ok(datosPrevios);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<DatosPrevios>> Post(DatosPrevios datosPrevios)
        {
            _unitOfWork.DatosPrevios.Add(datosPrevios);
            _unitOfWork.Save();
            if (datosPrevios == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Post), new { id = datosPrevios.Id }, datosPrevios);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DatosPrevios>> Put(int id, [FromBody] DatosPrevios datosPrevios)
        {
            if (datosPrevios == null)
                return NotFound();

            _unitOfWork.DatosPrevios.Update(datosPrevios);
            _unitOfWork.Save();

            return datosPrevios;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var datosPrevios = await _unitOfWork.DatosPrevios.GetByIdAsync(id);

            if (datosPrevios == null)
                return NotFound();

            _unitOfWork.DatosPrevios.Remove(datosPrevios);
            _unitOfWork.Save();

            return NoContent();
        }
    }
}
using CestaFeira.Application.DTO;
using CestaFeira.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CestaFeira.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _service;

        public ItemController(IItemService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await _service.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Post(ItemDto dto)
        {
            await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, ItemDto dto)
        {
            if (id != dto.Id) return BadRequest();
            await _service.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }

}

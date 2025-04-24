using Application.DTOs;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BooksController : ControllerBase
    {

        private readonly BookService _service;

        public BooksController(BookService service)
        {

            _service = service;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var books = await _service.GetAllAsync();
            return Ok(books);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var book = await _service.GetByIdAsync(id);
            return book == null ? NotFound() : Ok(book);

        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateBookDTO dto)
        {

            var book = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);

        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(int id, CreateBookDTO dto)
        { 
        
            var book = await _service.UpdateAsync(id, dto);
            return book == null ? NotFound(dto) : Ok(book);
        
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        { 
        
            var success = await _service.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        
        }

    }
}

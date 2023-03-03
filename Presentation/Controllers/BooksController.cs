using Entites.DataTransferObjects;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BookController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var books = await _manager.BookService.GetAllBooksAsync(false);
            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBookByIdAsync([FromRoute(Name = "id")] int id)
        {
            var book = await _manager.BookService.GetBookByIdAsync(id, false);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOneBookAsync([FromBody] BookDtoForInsertion bookDto)
        {
            if (bookDto is null)
                return BadRequest();

            if(!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            var book = await _manager.BookService.CreateAsync(bookDto);
            return StatusCode(201, book);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneBookAsync([FromRoute(Name = ("id"))] int id, BookDtoForUpdate bookDto)
        {

            if (bookDto == null)
                return BadRequest();

            if(!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _manager.BookService.UpdateAsync(id, bookDto, true);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneBookAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.BookService.GetBookByIdAsync(id, false);

            await _manager.BookService.DeleteAsync(id, false);
            return NoContent();
        }
    }
}

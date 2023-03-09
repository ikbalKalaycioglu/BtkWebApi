using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    //[ApiVersion("1.1", Deprecated = true)]
    [Route("api/bookv2")]
    [ApiController]
    public class BookV2Controller : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BookV2Controller(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var books = await _manager.BookService.GetAllBooksAsync(false);
            var booksV2 = books.Select(b => new
            {
                Name = b.Name,
                Id = b.Id,
            });
            return Ok(booksV2);
        }
    }
}

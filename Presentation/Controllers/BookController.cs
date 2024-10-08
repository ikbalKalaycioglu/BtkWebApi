﻿using Entites.DataTransferObjects;
using Entites.Exceptions;
using Entites.Models;
using Entites.RequestFeatures;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Presentation.Controllers
{
    //[ApiVersion("1.0")]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName ="v1")]
    //[ResponseCache(CacheProfileName = "5mins")]
    //[HttpCacheExpiration(CacheLocation =CacheLocation.Public,MaxAge =80)]
    public class BookController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BookController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize]
        [HttpHead]
        [ServiceFilter(typeof(ValidateMediaTypeAttribute))]
        [HttpGet(Name = "GetAllBooksAsync")]
        //[ResponseCache(Duration =60)]
        public async Task<IActionResult> GetAllBooksAsync([FromQuery] BookParameters bookParameters)
        {
            var linkParameters = new LinkParameters()
            {
                BookParameters = bookParameters,
                HttpContext = HttpContext
            };

            var result = await _manager.BookService.GetAllBooksAsync(linkParameters, false);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(result.metaData));
            return result.linkResponse.HasLinks ? Ok(result.linkResponse.LinkedEntites) : Ok(result.linkResponse.ShapedEntites);
        }
        [HttpGet("details")]
        [Authorize]
        public async Task<IActionResult> GetAllBooksWithDetailsAsync()
        {
            var books =await _manager.BookService.GetAllBooksWithDetailsAsync(false);
            return Ok(books);
        }


        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBookByIdAsync([FromRoute(Name = "id")] int id)
        {
            var book = await _manager.BookService.GetBookByIdAsync(id, false);
            return Ok(book);
        }
        [Authorize(Roles = "Admin,Editor")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOneBookAsync")]
        public async Task<IActionResult> CreateOneBookAsync([FromBody] BookDtoForInsertion bookDto)
        {
            var book = await _manager.BookService.CreateAsync(bookDto);
            return StatusCode(201, book);
        }

        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneBookAsync([FromRoute(Name = ("id"))] int id, BookDtoForUpdate bookDto)
        {
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
        [HttpOptions]
        public IActionResult GetBooksOptions()
        {
            Response.Headers.Add("Allow", "GET, PUT, POST, PATCH, DELETE, HEAD, OPTINOS");
            return Ok();
        }

    }
}

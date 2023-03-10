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
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _manager.CategoryService.GetAllCategoriesAsync(trackChanges: false));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCategoryAsync([FromRoute] int id)
        {
            return Ok(await _manager.CategoryService.GetOneCategoriesAsync(trackChanges: false, id: id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] Category category)
        {
            await _manager.CategoryService.CreateAsync(category);
            return Ok(category);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCategoryAsync([FromRoute(Name = "id")] int id)
        {
            var entity = await _manager.CategoryService.GetOneCategoriesAsync(id, trackChanges: false);
            await _manager.CategoryService.DeleteAsync(category: entity);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategoryAsync([FromBody] Category category)
        {
            await _manager.CategoryService.UpdateAsync(category);
            return Ok(category);
        }
    }
}

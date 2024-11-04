using HW_MVC_Core_11_Roles_2.Services;
using Microsoft.AspNetCore.Mvc;
using Shop_app.Models;

namespace HW_MVC_Core_11_Roles_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIServiceProductController : Controller
    {
        private readonly IServiceProduct _serviceProduct;
        public APIServiceProductController(IServiceProduct serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }
        [HttpGet("Read")]
        public async Task<JsonResult> Read()
        {
            return new JsonResult(await _serviceProduct.ReadAsync());
        }
        [HttpGet("{id}")]
        public async Task<JsonResult> Read(Guid ?id)
        {
            return Json(await _serviceProduct.GetByIdAsync(id));
        }
        [HttpPost("Create")]
        public async Task<JsonResult> Create(Product product)
        {
            return Json(await _serviceProduct.CreateAsync(product));
        }
        [HttpPut("{id}")]
        public async Task<JsonResult> Update(Guid?id, Product product)
        {
            return Json(await _serviceProduct.UpdateAsync(id,product));
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(Product product)
        {
            return Json(await _serviceProduct.DeleteAsync(product.Id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BackEnd_Нагорнов_А.В._ЛР4.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        [Route("{id:int:min(1)}")] //Получение продукта с id больше 0.
        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        [Route("category/{categoryName:minlength(3)}")] //Убедитесь, что имя категории больше 3 символов.
        public IActionResult ByCategory(string categoryName)
        {
            return View();
        }
    }
}

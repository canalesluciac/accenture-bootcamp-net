using Microsoft.AspNetCore.Mvc;

namespace WebMVCEjemplos.Controllers
{
    public class CalculatorController : Controller
    {
        //GET: /Calculator/MultByTwo/25
        public IActionResult MultByTwo(int num)
        {
            int result = num * 2;
            return Content(result.ToString());
        }

        //GET: /Calculator/Mult/100/200
        [Route("Calc/Mult/{num1:int}/{num2:int}")] // Solución por Ruta personalizada
        public IActionResult Mult(int num1, int num2)
        {
            int result = num1 * num2;
            return Content(result.ToString());
        }

        //GET: /Calculator/DivideByTen/33
        [HttpGet("Divide/{param?}")]                // Solución por HTTP
        public IActionResult DivideByTen(int param)
        {
            int result = param / 10;
            return Content(result.ToString());
        }
    }
}

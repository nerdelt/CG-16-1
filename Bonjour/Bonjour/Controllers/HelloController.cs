using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bonjour.Controllers
{
    public class HelloController : Controller
    {
        private string Message { get; set; }

        // GET: /<controller>/
        [HttpGet]
        [Route("/Hello")]
        public IActionResult Index()
        {

            return View();
        }


        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string language)
        {
            Message = CreateMessage(name, language);
            return Content(string.Format("<h1>{0}<h1>", Message),"text/html");
        }

        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}!<h1>", name), "text/html");
        }


        public static string CreateMessage(string name, string language)
        {
            switch (language)
            {
               
                case "english":
                    return $"Hello {name}!";
                case "french":
                    return $"Bonjour {name}!";
                case "italian":
                    return $"Ciao {name}!";   
                case "portuguese":
                    return $"Ola {name}!";
                case "spanish":
                    return $"Hola {name}!";        
                default:
                    return $"Hi {name}!";
            }
                

        }

       /* [Route ("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye!");
        }
        */
    }
}

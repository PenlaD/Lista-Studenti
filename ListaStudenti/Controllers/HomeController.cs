using ListaStudenti.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ListaStudenti.Controllers
{

    public class HomeController : Controller
    {
        private StudentContext StudentContext { get; set; }

        public HomeController(StudentContext studentContext)
        {
            StudentContext = studentContext;
        }

        public IActionResult Index()
        {
            var listaStudenti = StudentContext.Studenti.OrderBy(x => x.Nume).ToList();

            return View(listaStudenti);
        }

       
    }
}

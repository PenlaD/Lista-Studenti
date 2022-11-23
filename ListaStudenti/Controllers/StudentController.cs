using ListaStudenti.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaStudenti.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext StudentContext { get; set; }

        public StudentController(StudentContext studentContext)
        {
            StudentContext = studentContext;
        }
        [HttpGet]
        public IActionResult Adaugare()
        {
            ViewBag.Actiune = "Adauga";

            return View("Editare", new Student());
        }
        public IActionResult Editare(int id)
        {

            ViewBag.Actiune = "Editare";
            var student= StudentContext.Studenti.Find(id);

            return View(student);
        }
        [HttpPost]
        public IActionResult Editare(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentID == 0) StudentContext.Studenti.Add(student);
                else StudentContext.Studenti.Update(student);
                StudentContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Actiune = student.StudentID == 0 ? "Adaugare" : "Editare";
                return View(student);
            }
           

        }
        [HttpGet]
        public IActionResult Stergere(int id)
        {           
            var student = StudentContext.Studenti.Find(id);

            return View(student);
        }
        [HttpPost]
        public IActionResult Stergere(Student student)
        {
            StudentContext.Studenti.Remove(student);
            StudentContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}

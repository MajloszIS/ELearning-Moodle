using ELearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearning.Controllers
{
    public class SubjectsController : Controller
    {
        private static List<Subject> subjects = new List<Subject>
        {
            new Subject { 
                Id = 1, 
                Name = "Aplikacje webowe w ASP MVC", 
                Code = "AW-MVC", 
                Description = "Kontrolery, widoki, modele, Entity Framework Core." 
            },
            new Subject { 
                Id = 2, 
                Name = "Programowanie w JavaScript", 
                Code = "PAJS",
                Description = "Node.js, Express, REST API oraz Vue." 
            },
            new Subject { 
                Id = 3, 
                Name = "Bazy danych", 
                Code = "BD", 
                Description = "Model relacyjny, SQL, normalizacja." 
            }
        };

        private static int nextId = 4;

        // GET: /Subjects
        public IActionResult Index()
        {
            return View(subjects);
        }

        // GET: /Subjects/Details/5
        public IActionResult Details(int id)
        {
            Subject? subject = subjects.FirstOrDefault(s => s.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // GET: /Subjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Subjects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subject subject)
        {
            if (!ModelState.IsValid)
            {
                return View(subject);
            }

            subject.Id = nextId;
            nextId++;
            subject.CreatedAt = DateTime.Now;
            subjects.Add(subject);

            TempData["Success"] = "Dodano przedmiot.";
            return RedirectToAction("Index");
        }

        // GET: /Subjects/Edit/5
        public IActionResult Edit(int id)
        {
            Subject? subject = subjects.FirstOrDefault(s => s.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // POST: /Subjects/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Subject subject)
        {
            if (!ModelState.IsValid)
            {
                return View(subject);
            }

            Subject? existing = subjects.FirstOrDefault(s => s.Id == id);
            if (existing == null)
            {
                return NotFound();
            }

            existing.Name = subject.Name;
            existing.Code = subject.Code;
            existing.Description = subject.Description;

            TempData["Success"] = "Zapisano zmiany.";
            return RedirectToAction("Details", new { id = id });
        }

        // GET: /Subjects/Delete/5
        public IActionResult Delete(int id)
        {
            Subject? subject = subjects.FirstOrDefault(s => s.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // POST: /Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Subject? subject = subjects.FirstOrDefault(s => s.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            subjects.Remove(subject);

            TempData["Success"] = "Usunięto przedmiot.";
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Pizza_Hunt.Models;

namespace Pizza_Hunt.Controllers
{
    public class FoodController : Controller
    {
        private readonly PizzaContext _db;
        public FoodController(PizzaContext db)
        {
            _db = db;
        }
        public IActionResult pizza(string search)
        {
            IEnumerable<pizza> pizzaList = _db.pizza.Where(p => p.name.Contains(search) || p.ingredients.Contains(search) || search == null).ToList();
            return View(pizzaList);
        }

        public IActionResult paste(string search)
        {
            IEnumerable<pasta> pastaList = _db.pasta.Where(p => p.name.Contains(search) || p.ingredients.Contains(search) || search == null).ToList();
            return View(pastaList);
        }

        public IActionResult racoritoare(string search)
        {
            IEnumerable<refreshments> refreshmentsList = _db.refreshments.Where(p => p.name.Contains(search) || search == null).ToList();
            return View(refreshmentsList);
        }

        public IActionResult desert(string search)
        {
            IEnumerable<desert> desertList = _db.desert.Where(p => p.name.Contains(search) || search == null).ToList();
            return View(desertList);
        }

        [HttpGet]
        public IActionResult pizzaInsert()
        {

            pizza pizza = new pizza();
            return View(pizza);

        }
        [HttpPost]
        public IActionResult pizzaInsert(pizza pizza)
        {
            if (ModelState.IsValid)
            {
                _db.pizza.Add(pizza);
                _db.SaveChanges();
                return RedirectToAction("pizza");
            }
            return View(pizza);
        }

        [HttpGet]
        public IActionResult pasteInsert()
        {

            pasta pasta = new pasta();
            return View(pasta);

        }
        [HttpPost]

        public IActionResult pasteInsert(pasta pasta)
        {
            if (ModelState.IsValid)
            {
                _db.pasta.Add(pasta);
                _db.SaveChanges();
                return RedirectToAction("paste");
            }
            return View(pasta);
        }

        [HttpGet]
        public IActionResult desertInsert()
        {

            desert desert = new desert();
            return View(desert);

        }
        [HttpPost]
        public IActionResult desertInsert(desert desert)
        {
            if (ModelState.IsValid)
            {
                _db.desert.Add(desert);
                _db.SaveChanges();
                return RedirectToAction("desert");
            }
            return View(desert);
        }

        [HttpGet]
        public IActionResult racoritoareInsert()
        {

            refreshments refreshments = new refreshments();
            return View(refreshments);

        }
        [HttpPost]
        public IActionResult racoritoareInsert(refreshments refreshments)
        {
            if (ModelState.IsValid)
            {
                _db.refreshments.Add(refreshments);
                _db.SaveChanges();
                return RedirectToAction("racoritoare");
            }
            return View(refreshments);
        }

        public IActionResult pizzaDelete(int id)
        {
            pizza pizza = _db.pizza.Find(id);
            _db.pizza.Remove(pizza);
            _db.SaveChanges();
            return RedirectToAction("pizza");
        }

        public IActionResult pasteDelete(int id)
        {
            pasta pasta = _db.pasta.Find(id);
            _db.pasta.Remove(pasta);
            _db.SaveChanges();
            return RedirectToAction("paste");
        }

        public IActionResult desertDelete(int id)
        {
            desert desert = _db.desert.Find(id);
            _db.desert.Remove(desert);
            _db.SaveChanges();
            return RedirectToAction("desert");
        }

        public IActionResult racoritoareDelete(int id)
        {
            refreshments refreshments = _db.refreshments.Find(id);
            _db.refreshments.Remove(refreshments);
            _db.SaveChanges();
            return RedirectToAction("racoritoare");
        }

        [HttpGet]
        public IActionResult pizzaEdit(int id)
        {
            var pizza = _db.pizza.Where(x => x.pizzaId == id).FirstOrDefault();
            return View(pizza);
        }

        [HttpPost]
        public IActionResult pizzaEdit(pizza pizza)
        {
            if (ModelState.IsValid)
            {
                var pizza2 = _db.pizza.Where(x => x.pizzaId == pizza.pizzaId).FirstOrDefault();
                _db.pizza.Remove(pizza2);
                _db.pizza.Add(pizza);
                _db.SaveChanges();

            }
            return RedirectToAction("pizza");

        }

        [HttpGet]
        public IActionResult pasteEdit(int id)
        {
            var pasta = _db.pasta.Where(x => x.pastaId == id).FirstOrDefault();
            return View(pasta);
        }

        [HttpPost]
        public IActionResult pasteEdit(pasta pasta)
        {
            if (ModelState.IsValid)
            {
                var pasta2 = _db.pasta.Where(x => x.pastaId == pasta.pastaId).FirstOrDefault();
                _db.pasta.Remove(pasta2);
                _db.pasta.Add(pasta);
                _db.SaveChanges();

            }
            return RedirectToAction("paste");
        }

        [HttpGet]
        public IActionResult desertEdit(int id)
        {
            var desert = _db.desert.Where(x => x.desertId == id).FirstOrDefault();
            return View(desert);
        }

        [HttpPost]
        public IActionResult desertEdit(desert desert)
        {
            if (ModelState.IsValid)
            {
                var desert2 = _db.desert.Where(x => x.desertId == desert.desertId).FirstOrDefault();
                _db.desert.Remove(desert2);
                _db.desert.Add(desert);
                _db.SaveChanges();

            }
            return RedirectToAction("desert");

        }

        [HttpGet]
        public IActionResult racoritoareEdit(int id)
        {
            var refreshments = _db.refreshments.Where(x => x.refreshmentsId == id).FirstOrDefault();
            return View(refreshments);
        }

        [HttpPost]
        public IActionResult racoritoareEdit(refreshments refreshments)
        {
            if (ModelState.IsValid)
            {
                var refreshments2 = _db.refreshments.Where(x => x.refreshmentsId == refreshments.refreshmentsId).FirstOrDefault();
                _db.refreshments.Remove(refreshments2);
                _db.refreshments.Add(refreshments);
                _db.SaveChanges();

            }
            return RedirectToAction("racoritoare");
        }
    }
}

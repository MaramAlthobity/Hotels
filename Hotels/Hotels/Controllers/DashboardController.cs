using Hotels.Data;
using Hotels.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotels.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Delete(int id)
        {
            var hotelDel = _context.hotel.SingleOrDefault(x=>x.Id == id);

            if (hotelDel != null)
            {
                _context.hotel.Remove(hotelDel);
                _context.SaveChanges();
                ViewBag.msg = "Ok";
            }
            return RedirectToAction("Index");
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var hotel = _context.hotel.ToList();
            return View(hotel);
        }

        public IActionResult Rooms()
        {
            var hotel = _context.hotel.ToList();
            ViewBag.hotel = hotel;
            return View();
        }

        public IActionResult Edit(int id)
        {
            var hoteledit =
                _context.hotel.SingleOrDefault(x => x.Id == id);
            return View(hoteledit);
        }

        public IActionResult Update(Hotel hotel)
        {
            _context.hotel.Update(hotel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateNewHotel(Hotel hotels)
        {
            _context.hotel.Add(hotels);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}


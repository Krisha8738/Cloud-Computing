using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ISMTCollege.Data;
using ISMTCollege.Models;
using System.Diagnostics;

namespace ISMTCollege.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.FeaturedCourses = await _context.Courses.Where(c => c.IsActive).Take(3).ToListAsync();
            ViewBag.LatestNews = await _context.News.Where(n => n.IsPublished).OrderByDescending(n => n.PublishedAt).Take(3).ToListAsync();
            ViewBag.FacultyCount = await _context.Faculty.Where(f => f.IsActive).CountAsync();
            ViewBag.CourseCount = await _context.Courses.Where(c => c.IsActive).CountAsync();
            
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> Courses()
        {
            var courses = await _context.Courses.Where(c => c.IsActive).ToListAsync();
            return View(courses);
        }

        public async Task<IActionResult> Faculty()
        {
            var faculty = await _context.Faculty.Where(f => f.IsActive).ToListAsync();
            return View(faculty);
        }

        public async Task<IActionResult> News()
        {
            var news = await _context.News.Where(n => n.IsPublished).OrderByDescending(n => n.PublishedAt).ToListAsync();
            return View(news);
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.ContactForms.Add(contactForm);
                    await _context.SaveChangesAsync();
                    
                    TempData["SuccessMessage"] = "Thank you for your message! We'll get back to you soon.";
                    return RedirectToAction(nameof(Contact));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error saving contact form");
                    ModelState.AddModelError("", "An error occurred while sending your message. Please try again.");
                }
            }
            
            return View(contactForm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

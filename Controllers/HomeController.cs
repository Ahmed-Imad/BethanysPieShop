using BethanysPieShop.Models;
using BethanysPieShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _ieRepository;

        public HomeController(IPieRepository ieRepository)
        {
            _ieRepository = ieRepository;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _ieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}

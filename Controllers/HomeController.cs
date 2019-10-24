using Microsoft.AspNetCore.Mvc;
using UnitOfWorkSample.UnitOfWork;

namespace UnitOfWorkSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWorkBase _unitOfWorkBase;

        public HomeController(IUnitOfWorkBase unitOfWorkBase)
        {
            _unitOfWorkBase = unitOfWorkBase;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

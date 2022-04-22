using Microsoft.AspNetCore.Mvc;
using TotallyBSMVC.Models;
using TotallyBSMVC.ViewModels;

namespace TotallyBSMVC.Controllers
{
    public class ResultsController : Controller
    {
        private readonly IResultsRepo repo;

        public ResultsController(IResultsRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var results = repo.GetQuickResults();
                
                return View(results);
        }

        public IActionResult ViewFullResults(int id)
        {
            var results = repo.GetFullResults(id);
            var resultHeader = repo.GetQuickResult(id);
            var vm = new FullResultsVM
            {
                Results = results,
                SubResults = resultHeader
            };

            return View(vm);
        }

        public IActionResult ViewRatings()
        {
            var ratings = repo.GetRatings();

            return View(ratings);
        }
    }
}

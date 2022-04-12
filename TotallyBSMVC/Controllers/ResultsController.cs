﻿using Microsoft.AspNetCore.Mvc;
using TotallyBSMVC.Models;

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

        public IActionResult ViewFullResults(int sessionId)
        {
            var results = repo.GetFullResults(sessionId);

            return View(results);
        }
    }
}
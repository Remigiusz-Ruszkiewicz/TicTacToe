using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Helper.AbstractFactory;
using TicTacToe.Helper.Builder;
using TicTacToe.Repositories;

namespace TicTacToe.Controllers
{
    public class GameController : Controller
    {
        private readonly Repo repo;
        public GameController(Repo repo)
        {
            this.repo = repo;    
        }
        public IActionResult Small()
        {
            ViewBag.Results = repo.GetResults();
            return returnView(MethodBase.GetCurrentMethod().Name.ToLower());
        }

        private IActionResult returnView(string method)
        {
            var director = new Director(BuilderFactory.GetBuilder(method));
            director.Construct();
            return View(director.GetBoard);
        }

        public IActionResult Medium()
        {
            return returnView(MethodBase.GetCurrentMethod().Name.ToLower());
        }
    }
}
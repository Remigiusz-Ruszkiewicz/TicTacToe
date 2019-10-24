using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Helper.AbstractFactory;
using TicTacToe.Helper.Builder;

namespace TicTacToe.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Small()
        {
            string method = MethodBase.GetCurrentMethod().Name.ToLower();
            return returnView(method);
        }

        private IActionResult returnView(string method)
        {
            var director = new Director(BuilderFactory.GetBuilder(method));
            director.Construct();
            return View(director.GetBoard);
        }

        public IActionResult Medium()
        {
            string method = MethodBase.GetCurrentMethod().Name.ToLower();
            return returnView(method);
        }
    }
}
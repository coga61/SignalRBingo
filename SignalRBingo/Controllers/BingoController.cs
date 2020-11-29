using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBingo.Models;

namespace SignalRBingo.Controllers
{
    public class BingoController : Controller
    {
        List<BingoNumber> bingoNumbers = new List<BingoNumber>();
        public Random rng = new Random();
        public IActionResult Index()
        {
            HttpContext.Session.SetString("bingo", "");
            for (int i = 0; i < 3; i++)
            {
                bingoNumbers.Add(new BingoNumber(false, rng.Next(1, 13)));
            }
            
            
            return View(bingoNumbers);
        }

      
    }
}

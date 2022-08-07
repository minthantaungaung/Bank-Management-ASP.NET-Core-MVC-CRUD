using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Banking.Models;
using Microsoft.EntityFrameworkCore;
namespace Banking.Controllers
{
    public class BankController : Controller
    {
        private readonly ILogger<BankController> _logger;

        public BankController(ILogger<BankController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _BankList(string WestEast = null)
        {
            var context = new BankingContext();
            List<Bank> banks = null;
            if (WestEast == "1")
            {
                banks = context.Banks.FromSqlRaw($"GetBanksByWestEastValue '1'").ToList();
            }
            else if(WestEast == "0"){
                banks = context.Banks.FromSqlRaw($"GetBanksByWestEastValue '0'").ToList();
            }
            else
            {
                banks = context.Banks.FromSqlRaw($"GetAllBanks").ToList();
            }
            return PartialView(banks);
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

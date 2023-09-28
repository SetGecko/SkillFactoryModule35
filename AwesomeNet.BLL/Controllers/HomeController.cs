using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;


using AwesomeNet.Repository.Models;
using AwesomeNet.ViewModels.Account;
using Microsoft.AspNetCore.Identity;

namespace AwesomeNet.CNTR.Controllers
{
    //[Route("[controller]")] //только для теста
    //[ApiController] //только для теста
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;
 

        public HomeController(ILogger<HomeController> logger,SignInManager<User> signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;

        }

        /// <summary>
        /// только для теста
        /// </summary>
        [Route("Check_status")]
        public IActionResult CheckStatus()
        {
            return Ok("Hello!");
        }

        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
                return View(new MainViewModel());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
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

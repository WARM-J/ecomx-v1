using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dummy.Library.DataController;
namespace ecomx.Controllers
{
    public class DummyController : Controller
    {
        readonly DGetAllUser _getAllUser = new DGetAllUser();
        public async Task<IActionResult> Index()
        {
            var users = await _getAllUser.AllUser();
            return View(users);
        }
    }
}
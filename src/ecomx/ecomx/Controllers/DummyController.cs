using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dummy.Library.DataController;
using dummy.Library.Entity.Models;
namespace ecomx.Controllers
    
{
    public class DummyController : Controller
    {
        readonly DGetAllUser _getAllUser = new DGetAllUser();
        readonly DGetUser _getUser = new DGetUser();
        readonly DCreateUser _createUser = new DCreateUser();
        readonly DUpdateUser _updateUser = new DUpdateUser();
        readonly DDleteUser _deleteUser = new DDleteUser();
        public async Task<IActionResult> Index()
        {
            var users = await _getAllUser.AllUser();
            return View(users);
        }
        public async Task<IActionResult> UserDetail(int id)
        {
            var user = await _getUser.UserById(id);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserSave([Bind("Name","Age","Address")] TestModel user)
        {
            await _createUser.Create(user);
            return RedirectToAction("Index", "Dummy");
        }
        public async Task<IActionResult> UpdateUser(int id)
        {
            var user = await _getUser.UserById(id);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateUserSave([Bind("Id","Name", "Age", "Address")] TestModel user)
        {
            await _updateUser.Update(user);
            return RedirectToAction("Index", "Dummy");

        }
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _getUser.UserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteUserConfirm(int id)
        {
            await _deleteUser.Delete(id);
            return RedirectToAction("Index", "Dummy");
        }
    }
}
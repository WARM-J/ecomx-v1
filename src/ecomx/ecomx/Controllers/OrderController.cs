using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using order.Library.DataController;
using order.Library.Entity.Model;
using shoppingCart.Library.DataController;

namespace ecomx.Controllers
{
    public class OrderController : Controller
    {
        readonly DCreateOrder _createOrder = new DCreateOrder();
        readonly DCreateOrderDetail _createOrderDetail = new DCreateOrderDetail();
        readonly DGetCartByUserId _getCart = new DGetCartByUserId();
        readonly DGetOrderByUserId _getOrder = new DGetOrderByUserId();
        readonly DUpdateIsPlacedOrderInCart _updatePlacedOrder = new DUpdateIsPlacedOrderInCart();
        readonly DGetOrderCount _getCount = new DGetOrderCount();
        readonly DGetTotalPrice _getTotalPrice = new DGetTotalPrice();
        readonly DGetAllOrder _getGetAllOrder = new DGetAllOrder();
        readonly DGetOrderDetail _getOrdersDetails = new DGetOrderDetail();
        [HttpGet]
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CheckOut(OrderModel model)
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = "A2";
            if (userId != null)
            {
                var cart = await _getCart.CartByUserId(userId);
                if (cart != null)
                {
                    decimal total = await _getTotalPrice.Get(userId);
                    var orderNumber = Guid.NewGuid().GetHashCode().ToString("x");
                    await _createOrder.Create(model, userId, orderNumber, total);

                    await _createOrderDetail.Create(userId);
                    await _updatePlacedOrder.Update(userId);

                    ViewBag.Message = "Your Order Done Successfully , It takes 3/4 Hours in our WOrking Days";
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "ShoppingCart");
                }
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrder()
        {
            var orders = await _getGetAllOrder.GetAllOrder();
            return View(orders);
        }
        [HttpGet]
        public async Task<IActionResult> OrdersDetails(string orderNumber)
        {
            var user = await _getOrdersDetails.OrderDetailsById(orderNumber);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
}
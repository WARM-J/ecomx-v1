using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shoppingCart.Library.DataController;

namespace ecomx.Controllers
{
    public class ShoppingCartController : Controller
    {
        readonly DGetCartByUserId _getCartByUserId = new DGetCartByUserId();
        readonly DGetCartByCartId _getCartByCartId = new DGetCartByCartId();
        readonly DAddToCart _addToCart = new DAddToCart();
        readonly DUpdateCart _updateCart = new DUpdateCart();
        readonly DRemoveFromCart _removeFromCart = new DRemoveFromCart();

        public async Task<IActionResult> Cart()
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = "R1";
            if (userId != null)
            {
                var cart = await _getCartByUserId.CartByUserId(userId);
                return View(cart);
            }
            return NotFound();
        }
        public async Task<IActionResult> AddToCart(int productId, int quantity)
        {
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userId = "R1";

            await _addToCart.Create(productId, userId, quantity);
            return RedirectToAction("Index", "ShoppingCart");
        }
        public async Task<IActionResult> Remove(int cartId)
        {
            var cart = await _getCartByCartId.CartByCartId(cartId);
            if (cart == null)
            {
                return NotFound();
            }
            await _removeFromCart.Remove(cartId);
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.Library.DataController;
using Products.Library.Entity.Models;

namespace ecomx.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    public class ProductsController : Controller
    {
        readonly DAddProducts _addProducts = new DAddProducts();
        readonly DDeleteProducts _deleteProducts = new DDeleteProducts();
        readonly DGetAllProducts _getAllProducts = new DGetAllProducts();
        readonly DUpdataProducts _updataProducts = new DUpdataProducts();
        readonly DGetProductByID _getProductByID = new DGetProductByID();
        public async Task<IActionResult> Index()
        {
            var prod = await _getAllProducts.AllProducts();
            return View(prod);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductsSave([Bind("ProductName", "ImageUrl", "Rating", "Brand", "MRP", "Price", "Quantity")] ProductsInfo productsInfo)
        {
            await _addProducts.Create(productsInfo);
            return RedirectToAction("Index", "Products");

        }
        [Route("Products/UpdateProducts/{productID}")]
        public async Task<IActionResult> UpdateProducts(int productID)
        {
            var prod = await _getProductByID.GetProductsId(productID);
            if (prod == null)
            {
                return NotFound();
            }
            return View(prod);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateProductsSave([Bind("ProductID", "ProductName", "ImageUrl", "Rating", "Brand", "MRP", "Price", "Quantity")] ProductsInfo productsInfo)
        {
            await _updataProducts.Update(productsInfo);
            return RedirectToAction("Index", "Products");

        }
        [Route("Products/DeleteProducts/{productID}")]
        public async Task<IActionResult> DeleteProducts(int productID)
        {
            var prod = await _getProductByID.GetProductsId(productID);
            if (prod == null)
            {
                return NotFound();
            }
            return View(prod);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteProductsConfirm(int productID)
        {
            await _deleteProducts.Delete(productID);
            return RedirectToAction("Index", "Products");
        }
        [Route("Products/ProductsDetail/{productID}")]
        public async Task<IActionResult> ProductsDetail(int productID)
        {
            var prod = await _getProductByID.GetProductsId(productID);
            if (prod == null)
            {
                return NotFound();
            }
            return View(prod);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils.Messaging;
using Products.Library.DataController;
using Products.Library.Entity.Models;

namespace ecomx.Controllers
{

    public class ProductsController : Controller
    {
        readonly DAddProducts _addProducts = new DAddProducts();
        readonly DDeleteProducts _deleteProducts = new DDeleteProducts();
        readonly DGetAllProducts _getAllProducts = new DGetAllProducts();
        readonly DUpdataProducts _updataProducts = new DUpdataProducts();
        readonly DGetProductByID _getProductByID = new DGetProductByID();
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductsController(IWebHostEnvironment hostEnvironment)
        {
           // _addProducts = dAddProducts;
            this._hostEnvironment = hostEnvironment;
                
        }
        public async Task<IActionResult> Index()
        {
            var prod = await _getAllProducts.AllProducts();
            return View(prod);
        }
        public async Task<IActionResult>Search(string SearchText)
        {
            ViewData["CurrentFilter"] = SearchText;
            var Prod = await _getAllProducts.AllProducts();
                if (!String.IsNullOrEmpty(SearchText))
                {
                    Prod = Prod.Where(s => s.ProductName.Contains(SearchText));
                }
                else
                {
                    
                }
                return View(Prod.ToList());
            
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductsSave([Bind("ProductName", "Description", "ImageFile", "Rating", "Brand", "MRP", "Price", "Quantity")] ProductsInfo productsInfo)
        {
            //save image to the wwwroot/image
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(productsInfo.ImageFile.FileName);
            string extension = Path.GetExtension(productsInfo.ImageFile.FileName);
            productsInfo.ImageUrl= fileName = fileName + DateTime.Now.ToString("yymmssfff")+extension;
            string path = Path.Combine(wwwRootPath + "/image/", fileName);
            using(var fileStream=new FileStream(path, FileMode.Create))
            {
                await productsInfo.ImageFile.CopyToAsync(fileStream);
            }

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
        public async Task<IActionResult> UpdateProductsSave([Bind("ProductID", "ProductName", "Description", "ImageUrl", "Rating", "Brand", "MRP", "Price", "Quantity")] ProductsInfo productsInfo)
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
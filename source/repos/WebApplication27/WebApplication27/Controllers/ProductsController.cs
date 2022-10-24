using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication27.Models;

namespace WebApplication27.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>();

        public ProductsController()
        {

        }

        public ProductsController(List<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }

        public Product GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            return product;
        }
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}
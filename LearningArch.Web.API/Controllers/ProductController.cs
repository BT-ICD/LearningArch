using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningArch.DAL;
using LearningArch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningArch.Web.API.Controllers
{
    [Route("api/[controller]/[method]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> Get(){
            var res =  _productRepository.GetProducts();
            return res;
        }
        public Task<List<Product>> GetEF()
        {
            var res = _productRepository.GetProductsEF();
            return res;
        }
    }
}
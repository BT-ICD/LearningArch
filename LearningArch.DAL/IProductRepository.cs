using LearningArch.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningArch.DAL
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsEF();
        List<Product> GetProducts();
    }
}

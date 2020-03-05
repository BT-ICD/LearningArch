using LearningArch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningArch.DAL
{
    public class ProductRepository: IProductRepository
    {
        private LearningArchDbContext _context;
        public ProductRepository(LearningArchDbContext context)
        {
            _context = context;
        }

        Task<List<Product>> IProductRepository.GetProducts()
        {
            return _context.Product.ToListAsync();
        }
    }
}

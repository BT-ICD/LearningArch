using LearningArch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
namespace LearningArch.DAL
{
    public class ProductRepository: IProductRepository
    {
        private LearningArchDbContext _context;
        private string _cnnstring; 
        public ProductRepository(LearningArchDbContext context, string connectionString)
        {
            _context = context;
            _cnnstring = connectionString;
        }
        public Task<List<Product>> GetProductsEF()
        {
            //using entity framework
            var result = _context.Product.ToListAsync();
            return result ;
        }

        List<Product> IProductRepository.GetProducts()
        {

            //using dapper
            using (SqlConnection cnn = new SqlConnection(_cnnstring)) 
            {
               var result= cnn.Query<Product>("Select * From Product",null, null, true,null,System.Data.CommandType.Text);
                return result.ToList();
            }
        }
        
       


    }
}

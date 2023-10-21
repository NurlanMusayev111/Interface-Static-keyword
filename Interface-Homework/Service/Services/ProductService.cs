using Domain.Data;
using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService()
        {
            _context = new AppDbContext();
        }

        public decimal AverageOfPrice()
        {
            var products = _context.Products();

            int productCount = products.Length;
            decimal sumOfPrice = products.Sum(m => m.Price);

            return sumOfPrice / productCount;
        }

        public Product[] GetAll()
        {
            return _context.Products();
        }

        public Product[] GetAllByCategoryId(int id)
        {
            return _context.Products().Where(m => m.Category.Id ==  id).ToArray();
        }

        public Product[] GetAllByCategoryName(string categoryName)
        {
            return _context.Products().Where(m => m.Category.Name == categoryName).ToArray();
        }

        

        public int GetCount()
        {
            var products = _context.Products();
            return products.Length;
        }

        public Product[] OrderByDate()
        {
            return _context.Products().OrderBy(m => m.CreateDate).ToArray();    
        }

        public Product[] SearchByName(string searchText)
        {
            return _context.Products().Where(m => m.Name.ToLower().Trim().Contains(searchText.ToLower().Trim())).ToArray();
            
        }

        
    }
}

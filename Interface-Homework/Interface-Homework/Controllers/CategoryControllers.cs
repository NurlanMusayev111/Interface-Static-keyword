using Domain.Data;
using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Homework.Controllers
{
    public class CategoryControllers
    {
        private readonly ICategoryService _categoryService;

        public CategoryControllers()
        {
            _categoryService = new CategoryService();
        }


        public void GetAll()
        {
            var categories = _categoryService.GetAll();

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Name}");
            }
        }
    }
}

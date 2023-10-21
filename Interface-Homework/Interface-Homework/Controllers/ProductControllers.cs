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
    internal class ProductControllers
    {

        private readonly IProductService _productService;

        public ProductControllers()
        {
            _productService = new ProductService();
        }
        public void GetCount()
        {
            int count = _productService.GetCount();
            Console.WriteLine(count);
        }

        public void SearchProductByName()
        {
            Console.WriteLine("Add product search text");
            string searchText = Console.ReadLine(); 

            var result = _productService.SearchByName(searchText);

            foreach ( var item in result )
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.Category}");
            }
        }


        public void GetAll()
        {
            var res = _productService.GetAll();

            foreach ( var item in res)
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.Category.Name}");
            }
        }


        public void AverageOfPrice()
        {
            var res = _productService.AverageOfPrice();

            Console.WriteLine(res);
        }

        public void OrderByDate()
        {
            var date = _productService.OrderByDate();

            foreach (var item in date)
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.CreateDate : dd -MM-yyyy} - {item.Category.Name}");
            }
        }


        public void GetAllByCategoryName()
        {
            Console.WriteLine("Add category name :");

            string category = Console.ReadLine();

            var res = _productService.GetAllByCategoryName(category);

            foreach (var item in res)
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.CreateDate: dd -MM-yyyy} - {item.Category.Name}");
            }
        }


        public void GetAllByProductId()
        {

            Console.WriteLine("Please add category id");

            int categoryId = int.Parse(Console.ReadLine()); 
            var result = _productService.GetAllByCategoryId(categoryId);


            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Id}");
            }

        }
    }
}

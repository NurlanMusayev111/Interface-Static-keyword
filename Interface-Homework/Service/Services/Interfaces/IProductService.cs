using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        int GetCount();
        Product[] SearchByName(string searchText);
        Product[] GetAll();
        decimal AverageOfPrice();
        Product[] OrderByDate();
        Product[] GetAllByCategoryName(string serachCategory);

        Product[] GetAllByCategoryId(int id);
    }
}

using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
       Task<ResultProductDto> GetProduct(int id);
        Task CreateProductAsync(CreateProductDto createProductDto);
            Task CreateProductAsync(UpdateProductDto createProductDto);
            Task DeleteProductAsync(int id);
  
        Task GetByProductIdAsync(int id);   
    
    }
}

using Application.Dtos;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Impl
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }

        public async Task<ResponseDTO> GetByIdAsync(int id)
        {
            ResponseDTO response = new();
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null) 
            {
                response.Result = null;
                response.Message = "No Item Found";

                return response;
            }

            response.Result = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
            response.IsSuccess = true;
            response.Message = "Success";

            return response;
        }
    }
}

using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Services
{
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        
        private readonly ICategoryRepository _categoryRepository;

        public ProductViewModelService(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public ProductViewModel Get(int id)
        {
            var entity = _productRepository.Get(id);
            if (entity == null)
                return null;
                
            return _mapper.Map<ProductViewModel>(entity);
        }

        public IEnumerable<CategoryViewModel> GetAllCategories()
        {
            var list = _categoryRepository.GetAll();
            if (list == null)
                return new CategoryViewModel[] { };
            return _mapper.Map<IEnumerable<CategoryViewModel>>(list);
        }
        public IEnumerable<ProductViewModel> GetAll()
        {
            var list = _productRepository.GetAll();
            if (list == null)
                return new ProductViewModel[] { };

            return _mapper.Map<IEnumerable<ProductViewModel>>(list);
        }

        public void Insert(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Insert(entity);
        }

        public void Update(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _productRepository.Update(entity);
        }
    }
}

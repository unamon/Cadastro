using Cadastro.Domain.Entities;
using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
    public interface IProductViewModelService
    {
        ProductViewModel Get(int id);
        IEnumerable<ProductViewModel> GetAll();
        IEnumerable<CategoryViewModel> GetAllCategories();

        void Insert(ProductViewModel viewModel);
        void Update(ProductViewModel viewModel);
        void Delete(int id);
    }
}

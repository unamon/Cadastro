using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // public List<SelectListItem> Categories { get; } = new List<SelectListItem>
        // {
        //     new SelectListItem { Value = "", Text = "Selecione uma Categoria" },
        //     new SelectListItem { Value = "Eletrônicos", Text = "Eletrônicos" },
        //     new SelectListItem { Value = "Móveis", Text = "Móveis" },
        //     new SelectListItem { Value = "Livros", Text = "Livros"  },
        // };

    }
}

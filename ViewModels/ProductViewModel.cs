using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O valor é requerido.")]
        [DataType(DataType.Currency)]
        public Double Value { get; set; }

        // [Display(Name = "Categoria")]
        // public CategoryViewModel Category {get; set;}

        [Required(ErrorMessage = "A categoria é requerida.")]
        [Display(Name = "Categoria")]
        public string CategoryId { get; set; }

        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "0", Text = "Eletrônicos" },
            new SelectListItem { Value = "1", Text = "Brinquedos" },
            new SelectListItem { Value = "2", Text = "Móveis" },
            new SelectListItem { Value = "3", Text = "Livros"  },
        };

        [Display(Name = "Ativo")]
        public bool Active { get; set; }
    }
}

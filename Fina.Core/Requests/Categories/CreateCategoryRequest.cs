using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Categories
{
    public class CreateCategoryRequest : Request
    {
        [Required(ErrorMessage = "Titulo inválido")]
        [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Descrição inválida")]
        public string Description { get; set; } = string.Empty;
    }
}

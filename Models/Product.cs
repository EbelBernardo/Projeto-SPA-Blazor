using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Projeto_SPA_Blazor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Título é obrigatório")]
        [MaxLength(100, ErrorMessage = "O Título deve ter no máximo 100 caracteres")]
        [MinLength(3, ErrorMessage = "O Título deve ter no mínimo 3 caracteres")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Preço é obrigatório")]
        [DataType(DataType.Currency)]
        [Range(1, 10000, ErrorMessage = "O Preço deve ser entre 1 e 10000")]
        [Precision(7, 2)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "A Categoria é obrigatória")]
        [Range(1, 10000, ErrorMessage = "A Categoria deve ser entre 1 e 10000")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}

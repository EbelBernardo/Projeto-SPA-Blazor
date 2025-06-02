using System.ComponentModel.DataAnnotations;

namespace Projeto_SPA_Blazor.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Título é obrigatório")]
        [MaxLength(100, ErrorMessage = "O Título deve ter no máximo 100 caracteres")]
        [MinLength(3, ErrorMessage = "O Título deve ter no mínimo 3 caracteres")]
        public string Title { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}

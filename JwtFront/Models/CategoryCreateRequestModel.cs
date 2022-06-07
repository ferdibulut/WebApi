using System.ComponentModel.DataAnnotations;

namespace JwtFront.Models
{
    public class CategoryCreateRequestModel
    {
        [Required(ErrorMessage ="Kategori adı boş olamaz")]
        public string? Definition { get; set; }
    }
}

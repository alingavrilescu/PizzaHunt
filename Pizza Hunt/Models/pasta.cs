using System.ComponentModel;

namespace Pizza_Hunt.Models
{
    public class pasta
    {
        public int pastaId { get; set; }
        [DisplayName("Nume")]
        public string? name { get; set; }
        [DisplayName("Kcal")]
        public string? kcal { get; set; }
        [DisplayName("Link img")]
        public string? img_url { get; set; }
        [DisplayName("Ingrediente")]
        public string? ingredients { get; set; }
        public ICollection<FavoritePasta>? FavoritePasta { get; set; }
    }
}

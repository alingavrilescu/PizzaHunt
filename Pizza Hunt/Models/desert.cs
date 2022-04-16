using System.ComponentModel;

namespace Pizza_Hunt.Models
{
    public class desert
    {
        public int desertId { get; set; }
        [DisplayName("Nume")]
        public string? name { get; set; }
        [DisplayName("Kcal")]
        public string? kcal { get; set; }
        [DisplayName("Link img")]
        public string? img_url { get; set; }
        public ICollection<FavoriteDesert>? FavoriteDesert { get; set; }
    }
}

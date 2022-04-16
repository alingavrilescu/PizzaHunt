using System.ComponentModel;

namespace Pizza_Hunt.Models
{
    public class refreshments
    {
        public int refreshmentsId { get; set; }
        [DisplayName("Nume")]
        public string? name { get; set; }
        [DisplayName("Kcal")]
        public string? kcal { get; set; }
        [DisplayName("Link imagine")]
        public string? img_url { get; set; }
        public ICollection<FavoriteRefreshment>? FavoriteRefreshment { get; set; }
    }
}

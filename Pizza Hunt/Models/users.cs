namespace Pizza_Hunt.Models
{
    public class users
    {
        public int usersID { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? password { get; set; }
        public ICollection<FavoritePizza>? FavoritePizza { get; set; }
        public ICollection<FavoritePasta>? FavoritePasta { get; set; }
        public ICollection<FavoriteDesert>? FavoriteDesert { get; set; }
        public ICollection<FavoriteRefreshment>? FavoriteRefreshment { get; set; }
    }
}

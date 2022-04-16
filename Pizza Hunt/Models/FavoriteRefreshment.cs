namespace Pizza_Hunt.Models
{
    public class FavoriteRefreshment
    {
        public int usersID { get; set; }
        public virtual users? users { get; set; }
        public int refreshmentsID { get; set; }
        public virtual refreshments? refreshments { get; set; }
    }
}

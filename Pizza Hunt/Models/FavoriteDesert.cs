namespace Pizza_Hunt.Models
{
    public class FavoriteDesert
    {
        public int usersID { get; set; }
        public virtual users? users { get; set; }
        public int desertID { get; set; }
        public virtual desert? desert { get; set; }
    }
}

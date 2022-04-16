namespace Pizza_Hunt.Models
{
    public class FavoritePasta
    {
        public int usersID { get; set; }
        public virtual users? users { get; set; }
        public int pastaID { get; set; }
        public virtual pasta? pasta { get; set; }
    }
}

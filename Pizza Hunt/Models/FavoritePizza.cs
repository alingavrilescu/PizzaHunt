namespace Pizza_Hunt.Models
{
    public class FavoritePizza
    {
        public int usersID { get; set; }
        public virtual users? users { get; set; }
        public int pizzaID { get; set; }
        public virtual pizza? pizza { get; set; }
    }
}

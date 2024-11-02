namespace SupermarketWEB.Models
{
    public class Provider
    {
        public int Id { get; set; } //Será la llave primaria
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

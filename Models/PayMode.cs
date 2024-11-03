namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; } //Será la llave primaria
        public string payment_method { get; set; }
        public string Cedula { get; set; }
        public string Phone { get; set; }
    }
}

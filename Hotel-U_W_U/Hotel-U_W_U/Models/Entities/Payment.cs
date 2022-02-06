namespace Hotel_U_W_U.Models.Entities
{
    public class Payment
    {
        public string cardNumber { get; set; }
        public string fullName { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string cvc { get; set; }
        public int value { get; set; }
    }
}

namespace DDD.BuyerAgregate
{
    public class CardType
    {
        public string NumberCard { get; set; }
        public string ExpiryDate { get; set; }
        public string CardholdersName { get; set; }

        private PaymentSystem PaymentSystem { get; set; }

        public CardType(string numberCard, string expiryDate, string cardholdersName, PaymentSystem paymentSystem)
        {
            NumberCard = numberCard;
            ExpiryDate = expiryDate;
            CardholdersName = cardholdersName;
            PaymentSystem = paymentSystem;
        }
    }

    public enum PaymentSystem
    {
        Visa,
        Mastercard,
        Mir
    }
}
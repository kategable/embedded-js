namespace partner.integration.Models
{
    public class PaymentRequestModel
    {
        /// <summary>
        /// Partner provovided number of transaction
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Partner provided Credit card object
        /// </summary>
        public CreditCardModel CreditCard { get; set; }

        /// <summary>
        /// Not used calculated on the server
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Not used calculated on the server
        /// </summary>
        public string GeoLocation { get; set; }

        /// <summary>
        /// Not used calculated on the server
        /// </summary>
        public string UserAgent { get; set; }
    }
}

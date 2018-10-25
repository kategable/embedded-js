namespace partner.integration.Models
{
    public class CreditCardModel
    {
        //public int Id { get; set; }
        /// <summary>
        /// holds Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// holds Number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// holds ExpirationMonth
        /// </summary>
        public int ExpirationMonth { get; set; }

        /// <summary>
        /// holds ExpirationYear
        /// </summary>
        public int ExpirationYear { get; set; }

        /// <summary>
        /// holds CVV
        /// </summary>
        public string CVV { get; set; }
    }
}
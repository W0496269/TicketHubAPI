using System.ComponentModel.DataAnnotations;

namespace TicketHubAPI.Models
{
    public class PurchaseRequest
    {
        [Required]
        public int ConcertId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required, Range(1, 10)]
        public int Quantity { get; set; }

        [Required, CreditCard]
        public string CreditCard { get; set; }

        [Required]
        public string Expiration { get; set; } // MM/YY format

        [Required, StringLength(3, MinimumLength = 3)]
        public string SecurityCode { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}

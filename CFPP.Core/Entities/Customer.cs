using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CFPP.Core.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Column("CustomerId")]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Customer name is required")]
        [MaxLength(5, ErrorMessage = "Length must be less then 50 characters")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Client Code is required")]
        [MaxLength(5, ErrorMessage = "Length must be less then 50 characters")]

        public string ClientCode { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone No is required")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Contact Person Name is required")]
        [MaxLength(5, ErrorMessage = "Length must be less then 50 characters")]
        public string ContactPersonName { get; set; }

        public ICollection<Case> Cases { get; set; }
    }
}

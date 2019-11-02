using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiBanHang_Group1.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public ICollection<Invoice> Invoices  { get; set; }

    }
}

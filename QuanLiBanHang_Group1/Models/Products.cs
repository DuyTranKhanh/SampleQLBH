using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiBanHang_Group1.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string dvi{ get; set; }
        public string cost { get; set; }


        public List<InvoiceDetails> InvoiceDetails { get; set; }
    }
}


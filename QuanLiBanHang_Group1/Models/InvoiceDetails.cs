using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace QuanLiBanHang_Group1.Models
{
    public class InvoiceDetails
    {
        [Key]
        [Column(Order = 1)]

        public int InvoiceId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProID { get; set; }
        public int amount { get; set; }

        public Invoice Invoice { get; set; }
        public Products Products { get; set; }
    }
}

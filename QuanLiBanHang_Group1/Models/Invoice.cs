using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiBanHang_Group1.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CusID { get; set; }
        public int StaffID { get; set; }
        public DateTime Receive { get; set; }
        public DateTime GetDate
        {
            get; set;
        }

        public virtual Customer Customer { get; set; }
        public List<InvoiceDetails> InvoiceDetails { get; set; }

    }
}

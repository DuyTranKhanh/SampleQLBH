using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLiBanHang_Group1.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DayApply { get; set; }

    }
}

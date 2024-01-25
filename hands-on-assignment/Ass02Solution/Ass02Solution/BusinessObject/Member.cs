using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [MaxLength(100)]
        public string Email { get; set; } = null!;
        [MaxLength(40)]
        public string CompanyName { get; set; } = null!;
        [MaxLength(15)]
        public string City { get; set;} = null!;
        [MaxLength(15)]
        public string Country { get; set; } = null!;
        [MaxLength(30)]
        public string Password { get; set; } = null!;

        public ICollection<Order>? Orders { get; set; }
        
    }
}

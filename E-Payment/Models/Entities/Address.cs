using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Address : BaseEntity
    {
        [Key]
        public int AddressId { get; set; }
        [StringLength(500)]
        public string AddressString { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}

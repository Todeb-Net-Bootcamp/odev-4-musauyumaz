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
    public class CorporateCustomer : User
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [StringLength(10)]
        public string TaxNumber { get; set; }
        public virtual User User { get; set; }
    }
}

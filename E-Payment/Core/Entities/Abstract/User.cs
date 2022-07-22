using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public abstract class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(25)]
        public string Password { get; set; }
    }
}

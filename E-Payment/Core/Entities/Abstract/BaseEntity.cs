using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

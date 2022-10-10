using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_fiorello.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

    }
}

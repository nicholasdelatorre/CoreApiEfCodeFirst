using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Domain
{
    public abstract class IdentifiedEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

        public IdentifiedEntity() {
            IsActive = true;
        }
    }
}

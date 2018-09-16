using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Domain
{
    public class UserType : IdentifiedEntity
    {
        public string Description { get; set; }
    }
}

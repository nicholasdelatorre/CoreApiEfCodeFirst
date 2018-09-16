using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Domain
{
    public class User : IdentifiedEntity
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime RegisterDate { get; set; }
        public int? SuperiorId { get; set; }
        public User Superior { get; set; }
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
    }
}

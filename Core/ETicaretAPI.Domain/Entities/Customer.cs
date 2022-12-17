using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    //Customer ile order araasında 1'e çok(n) ilişki mevcut. Bir customer'ın birden fazla orderı olabilir.
    //Ancak bir order yalnızca bir customer'a aittir.
    public class Customer : BaseEntity 
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

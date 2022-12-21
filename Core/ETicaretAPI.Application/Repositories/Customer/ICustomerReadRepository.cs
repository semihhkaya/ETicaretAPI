using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    //GenericRepoDesignPattern Solıdın s kısmına aykırı sebebi ise hem read hem write için aynı bölgeye kod yazıyorduk
    //biz de read ve write olarak repoları ayırdık ve bu duruma göre kod yazdık.
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
    }
}

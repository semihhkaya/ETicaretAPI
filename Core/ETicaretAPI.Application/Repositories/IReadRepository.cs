using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{//Sorgu bazlı çalışırken (read) IQueryable Write odaklı isek (CRUD) ->IEnumerable //Customize edebiliyoruz. burdaki işlemleri projeye implement edip kendi işimize yarayn//çalışmalar gerçekleştirebiliyoruz.
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity //Sadece query odaklı Select sorguları
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method); //Şartlı kayıtlar
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method); //Şarta uyan tekil kayıt //Asenktron çalışacaksa isim bu
        Task<T> GetByIdAsync(string id);


    }
}

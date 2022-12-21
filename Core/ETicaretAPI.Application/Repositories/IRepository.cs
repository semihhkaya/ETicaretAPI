using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Verilecek t tipi bir class olmak zorunda //Constrait?
//Generic repo genelleştirilebilir. Tür bazlı 
//Bütün entity repolarında olması gereken şeyleri buraya koyalım (evrensel)

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}

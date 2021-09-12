/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using Microsoft.EntityFrameworkCore;
using Test.DataTier.BaseConnect;
using Test.DataTier.Models;
namespace Test.BusinessTier.Generations.Repositories
{
    public partial interface ISysBookRepository :IBaseRepository<SysBook>
    {
    }
    public partial class SysBookRepository :BaseRepository<SysBook>, ISysBookRepository
    {
         public SysBookRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}


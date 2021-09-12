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
    public partial interface ISysLockJwtRepository :IBaseRepository<SysLockJwt>
    {
    }
    public partial class SysLockJwtRepository :BaseRepository<SysLockJwt>, ISysLockJwtRepository
    {
         public SysLockJwtRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}


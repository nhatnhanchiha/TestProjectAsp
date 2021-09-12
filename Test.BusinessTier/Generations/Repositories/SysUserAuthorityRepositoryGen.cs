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
    public partial interface ISysUserAuthorityRepository :IBaseRepository<SysUserAuthority>
    {
    }
    public partial class SysUserAuthorityRepository :BaseRepository<SysUserAuthority>, ISysUserAuthorityRepository
    {
         public SysUserAuthorityRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}


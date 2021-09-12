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
    public partial interface ISysUserRepository :IBaseRepository<SysUser>
    {
    }
    public partial class SysUserRepository :BaseRepository<SysUser>, ISysUserRepository
    {
         public SysUserRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}


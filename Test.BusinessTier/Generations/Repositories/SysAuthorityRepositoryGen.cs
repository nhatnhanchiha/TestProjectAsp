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
    public partial interface ISysAuthorityRepository :IBaseRepository<SysAuthority>
    {
    }
    public partial class SysAuthorityRepository :BaseRepository<SysAuthority>, ISysAuthorityRepository
    {
         public SysAuthorityRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}


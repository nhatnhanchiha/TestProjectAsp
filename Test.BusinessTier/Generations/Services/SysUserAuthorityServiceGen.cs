/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using Test.DataTier.BaseConnect;
using Test.DataTier.Models;
using Test.BusinessTier.Generations.Repositories;
namespace Test.BusinessTier.Generations.Services
{
    
    public partial interface ISysUserAuthorityService:IBaseService<SysUserAuthority>
    {
    }
    public partial class SysUserAuthorityService:BaseService<SysUserAuthority>,ISysUserAuthorityService
    {
        public SysUserAuthorityService(IUnitOfWork unitOfWork,ISysUserAuthorityRepository repository):base(unitOfWork,repository){}
    }
}

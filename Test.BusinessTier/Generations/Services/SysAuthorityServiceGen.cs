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
    
    public partial interface ISysAuthorityService:IBaseService<SysAuthority>
    {
    }
    public partial class SysAuthorityService:BaseService<SysAuthority>,ISysAuthorityService
    {
        public SysAuthorityService(IUnitOfWork unitOfWork,ISysAuthorityRepository repository):base(unitOfWork,repository){}
    }
}

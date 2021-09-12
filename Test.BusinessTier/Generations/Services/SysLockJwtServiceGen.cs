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
    
    public partial interface ISysLockJwtService:IBaseService<SysLockJwt>
    {
    }
    public partial class SysLockJwtService:BaseService<SysLockJwt>,ISysLockJwtService
    {
        public SysLockJwtService(IUnitOfWork unitOfWork,ISysLockJwtRepository repository):base(unitOfWork,repository){}
    }
}

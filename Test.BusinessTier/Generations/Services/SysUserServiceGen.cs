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
    
    public partial interface ISysUserService:IBaseService<SysUser>
    {
    }
    public partial class SysUserService:BaseService<SysUser>,ISysUserService
    {
        public SysUserService(IUnitOfWork unitOfWork,ISysUserRepository repository):base(unitOfWork,repository){}
    }
}

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
    
    public partial interface ISysBookService:IBaseService<SysBook>
    {
    }
    public partial class SysBookService:BaseService<SysBook>,ISysBookService
    {
        public SysBookService(IUnitOfWork unitOfWork,ISysBookRepository repository):base(unitOfWork,repository){}
    }
}

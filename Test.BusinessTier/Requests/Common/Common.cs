using System.Collections.Generic;

namespace Test.BusinessTier.Requests.Common
{
    public class PageInfo
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }

    public class IdsReq
    {
        public List<int> Ids { get; set; }
    }
}
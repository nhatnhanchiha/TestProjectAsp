using System;
using System.Collections.Generic;

#nullable disable

namespace Test.DataTier.Models
{
    public partial class SysLockJwt
    {
        public long UserId { get; set; }
        public long? RebasedTime { get; set; }

        public virtual SysUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Test.DataTier.Models
{
    public partial class SysUserAuthority
    {
        public long SysUserId { get; set; }
        public string SysAuthorityAuthorityId { get; set; }

        public virtual SysAuthority SysAuthorityAuthority { get; set; }
        public virtual SysUser SysUser { get; set; }
    }
}

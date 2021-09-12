using System;
using System.Collections.Generic;

#nullable disable

namespace Test.DataTier.Models
{
    public partial class SysAuthority
    {
        public SysAuthority()
        {
            SysUserAuthorities = new HashSet<SysUserAuthority>();
        }

        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public string AuthorityId { get; set; }
        public string ParentId { get; set; }
        public string AuthorityName { get; set; }
        public string DefaultRouter { get; set; }

        public virtual ICollection<SysUserAuthority> SysUserAuthorities { get; set; }
    }
}

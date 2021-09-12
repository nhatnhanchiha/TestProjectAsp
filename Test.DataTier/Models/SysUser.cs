using System;
using System.Collections.Generic;

#nullable disable

namespace Test.DataTier.Models
{
    public partial class SysUser
    {
        public SysUser()
        {
            SysBooks = new HashSet<SysBook>();
            SysUserAuthorities = new HashSet<SysUserAuthority>();
        }

        public long Id { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }

        public virtual SysLockJwt SysLockJwt { get; set; }
        public virtual ICollection<SysBook> SysBooks { get; set; }
        public virtual ICollection<SysUserAuthority> SysUserAuthorities { get; set; }
    }
}

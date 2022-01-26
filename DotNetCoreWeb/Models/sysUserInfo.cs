using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.Models
{
    public class sysUserInfo : Base
    {
        [Key]
        [DisplayName("使用者編號")]
        [MaxLength(36)]
        public string UID { get; set; }
        [DisplayName("使用者名稱")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("使用者地址")]
        [MaxLength(255)]
        public string Address { get; set; }
        [DisplayName("使用者EMAIL")]
        [MaxLength(255)]
        public string Email { get; set; }
        [DisplayName("使用者公司")]
        [MaxLength(100)]
        public string Company { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.Models
{
    public class sysGroupMapping : Base
    {
        [Key]
        [DisplayName("群組編號")]
        [MaxLength(36)]
        public string ObjID { get; set; }
        [DisplayName("使用者編號")]
        [MaxLength(36)]
        public string UID { get; set; }
        [DisplayName("狀態")]
        [MaxLength(1)]
        public string State { get; set; }
    }
}

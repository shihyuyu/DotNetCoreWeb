using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.Models
{
    public class sysGroup : Base
    {
        [Key]
        [DisplayName("群組編號")]
        [MaxLength(36)]
        public string ObjID { get; set; }
        [DisplayName("父節點")]
        [MaxLength(36)]
        public string PID { get; set; }
        [DisplayName("群組名稱")]
        [MaxLength(50)]
        public string ObjName { get; set; }
    }
}

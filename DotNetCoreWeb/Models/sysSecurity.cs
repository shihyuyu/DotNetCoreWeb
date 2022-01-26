using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.Models
{
    public class sysSecurity : Base
    {
        [Key]
        [DisplayName("使用者編號")]
        [MaxLength(36)]
        public string UID { get; set; }
        [DisplayName("使用者名稱")]
        [MaxLength(100)]
        public string LoginID { get; set; }
        [DisplayName("使用者地址")]
        [MaxLength(100)]
        public string Password { get; set; }
        [DisplayName("狀態")]
        [MaxLength(1)]
        public string State { get; set; }  // 0:停用 1:啟用
        [DisplayName("啟用日")]
        [MaxLength(8)]
        public string SDate { get; set; } // YYYYMMDD
        [DisplayName("停用日")]
        [MaxLength(8)]
        public string EDate { get; set; } // YYYYMMDD
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DotNetCoreWeb.Models
{
    public class Base
    {
        [DisplayName("權限遮罩")]
        [DefaultValue(7)]
        public int mask { get; set; }
        [DisplayName("新增者")]
        [DefaultValue("")]
        public string CreateBy { get; set; }
        [DisplayName("編輯者")]
        [DefaultValue("")]
        public string ReviseBy { get; set; }
        [DisplayName("刪除者")]
        [DefaultValue("")]
        public string DeleteBy { get; set; }
        [DisplayName("新增群組")]
        [DefaultValue("")]
        public string CreateGrp { get; set; }
        [DisplayName("編輯群組")]
        [DefaultValue("")]
        public string ReviseGrp { get; set; }
        [DisplayName("刪除群組")]
        public string DeleteGrp { get; set; }
        [DisplayName("新增時間")]
        [DefaultValue(null)]
        public DateTime? CreateTime { get; set; }
        [DisplayName("編輯時間")]
        [DefaultValue(null)]
        public DateTime? ReviseTime { get; set; }
        [DisplayName("刪除時間")]
        [DefaultValue(null)]
        public DateTime? DeleteTime { get; set; }
    }
}
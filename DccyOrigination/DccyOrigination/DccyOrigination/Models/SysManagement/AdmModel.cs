using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models.SysManagement
{
    /// <summary>
    /// 系统管理父类
    /// </summary>
    public class AdmModel  :Entity
    { 
        /// <summary>
        /// 父Id
        /// </summary>
        [Display(Name ="父ID")]
        public int Pid { get; set; }
        /// <summary>
        /// guid
        /// </summary>
        [Display(Name ="Guid")]
        public string Guid { get; set; }
        /// <summary>
        /// 父GUiD
        /// </summary>
        [Display(Name ="PGuid")]
        public string PGuid { get; set; }
  

    }
}

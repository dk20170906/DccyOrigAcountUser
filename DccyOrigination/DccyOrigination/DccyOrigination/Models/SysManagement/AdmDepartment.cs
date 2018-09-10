using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models.SysManagement
{
    [Table("admDepartment")]
    public class AdmDepartment :AdmModel
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        [Display(Name ="部门名称")]
         public string DepName { get; set; }
        /// <summary>
        /// 子菜单集合
        /// </summary>
        public List<AdmDepartment> Children = new List<AdmDepartment>();
    }
}

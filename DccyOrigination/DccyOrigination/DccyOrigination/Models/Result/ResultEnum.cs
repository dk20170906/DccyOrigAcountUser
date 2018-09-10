using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models.Result
{
    public enum ResultEnum
    {
        [Description("操作成功")]
        SUCCESS = 200,
        [Description("操作失败")]
        ERROR = 300,
        [Description("未登录")]
        NOTLOGGED =301,
        [Description("无部门相关数据")]
        NODEP =302,
        [Description("无角色相关数据")]
        NOROLE =303,
        [Description("无权限相关数据")]
        NOJUR =304,
        [Description("无子用户相关数据")]
        NOUSER = 305,


        [Description("可授权")]
        AUTHORIZED =100,
        [Description("可访问")]
        ACCESSIBILITY =101,
       



    }
}

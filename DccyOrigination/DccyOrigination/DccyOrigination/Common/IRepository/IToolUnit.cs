using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Common.IRepository
{
    public interface IToolUnit
    {
        /// <summary>
        /// 生成随机的字符串
        /// </summary>
        /// <param name="codeCount"></param>
        /// <returns></returns>
        string CreateRandomCode(int codeCount);
        /// <summary>
        /// 创建验证码图片
        /// </summary>
        /// <param name="validateCode"></param>
        /// <returns></returns>
        byte[] CreateValidateGraphic(string validateCode);


        /// <summary>

        /// 获取枚举的描述

        /// </summary>

        /// <param name="en">枚举</param>

        /// <returns>返回枚举的描述</returns>

        string GetEnumDescriptionByReflex(Enum en);
    }
}

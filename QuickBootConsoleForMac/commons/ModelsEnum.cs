using System;
namespace EasyTools.common.@enum
{
    /// <summary>
    /// 模块枚举类
    /// </summary>
    public enum ModelsEnum
    {
        /// <summary>
        /// 获取当前时间时间戳的工具模块
        /// 此处的名称必须与工具模块的实现类类名一致
        /// </summary>
        NowTimestampToolModel = 1,

        /// <summary>
        /// 获取某时间时间戳的工具模块
        /// </summary>
        DateTimeToTimestampToolModel = 2,
    }
}

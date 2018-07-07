using System;
namespace QuickBootConsoleForMac.service
{
    /// <summary>
    /// 工具模块接口
    /// </summary>
    public interface IToolModel
    {
        /// <summary>
        /// 执行
        /// </summary>
        /// <returns>执行结果</returns>
        /// <param name="param">入参</param>
        string exec(params object[] param);

        /// <summary>
        /// 是否存在入参
        /// </summary>
        /// <returns>true-存在入参；false-不存在入参</returns>
        bool existsInputParam();

        /// <summary>
        /// 是否存在出参
        /// </summary>
        /// <returns>true-存在出参；false-不存在出参</returns>
        bool existsOutputParam();

        /// <summary>
        /// 读取并获取到入参
        /// </summary>
        /// <returns>用户从控制台输入的入参</returns>
        string readAndGetInputParam();

        /// <summary>
        /// 输出执行结果
        /// </summary>
        /// <param name="inputParamValue">用户从控制台输入的原值</param>
        /// <param name="execResult">结果字符串</param>
        void outputExecResult(string inputParamValue, string execResult);
    }
}

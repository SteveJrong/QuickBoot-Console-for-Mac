using System;
namespace QuickBootConsoleForMac.service.impl
{
    /// <summary>
    /// 获取当前时间时间戳的工具模块
    /// </summary>
    public class NowTimestampToolModel : IToolModel
    {
        public string exec(params object[] param)
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        public bool existsInputParam()
        {
            return true;
        }

        public bool existsOutputParam()
        {
            return true;
        }

        public string readAndGetInputParam()
        {
            return null;
        }

        public void outputExecResult(string inputParamValue, string execResult)
        {
            Console.WriteLine("当前时间的时间戳为：" + execResult);
        }
    }
}

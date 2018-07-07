using System;
namespace QuickBootConsoleForMac.service.impl
{
    /// <summary>
    /// 获取某时间时间戳的工具模块
    /// </summary>
    public class DateTimeToTimestampToolModel : IToolModel
    {
        public string exec(params object[] param)
        {

            DateTime dateTime = Convert.ToDateTime(param[0]);
            TimeSpan ts = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0);
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
            Console.WriteLine("请输入格式为 yyyy-MM-dd 格式的时间：");
            return Console.ReadLine();
        }

        public void outputExecResult(string inputParamValue, string execResult)
        {
            Console.WriteLine(inputParamValue + "的时间戳为：" + execResult);
        }
    }
}

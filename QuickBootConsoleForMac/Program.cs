using System;
using System.Collections.Generic;
using System.Text;
using QuickBootConsoleForMac.commons;
using QuickBootConsoleForMac.service;

namespace QuickBootConsoleForMac
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> allToolModels = ToolModelFactory.getToolModelCollections();

            #region 设置欢迎标语和使用方法
            Console.WriteLine(Constants.WELCOME_SLOGAN + "\n" + Constants.WELCOME_DESCRIPTION);
            StringBuilder strBuilder = new StringBuilder();
            foreach (var item in allToolModels)
            {
                strBuilder.AppendLine(item.Key + "." + item.Value);
            }
            Console.WriteLine(strBuilder);
            #endregion

            while (true) {
                string consoleInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(consoleInput) && !"0".Equals(consoleInput))
                {
                    int consoleInputNum = Int32.Parse(consoleInput);
                    Type t = Type.GetType("QuickBootConsoleForMac.service.impl." + allToolModels[consoleInputNum]);
                    IToolModel toolModel = (IToolModel)Activator.CreateInstance(t);
                    // 是否存在入参，若存在，则需要使用控制台读入
                    bool existsInputParam = toolModel.existsInputParam();
                    string inputParam = null;
                    string execResult = null;

                    if(existsInputParam) {
                        while(true) 
                        {
                            try
                            {
                                inputParam = toolModel.readAndGetInputParam();
                                execResult = toolModel.exec(inputParam);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(Constants.INPUT_ERROR_SLOGAN);
                                continue;
                            }
                        }
                        toolModel.outputExecResult(inputParam, execResult);
                    } else {
                        // 不存在入参，直接执行工具模块的功能并输出执行结果
                        execResult = toolModel.exec();
                        toolModel.outputExecResult(inputParam, execResult);
                    }
                } else if (!String.IsNullOrEmpty(consoleInput) && "0".Equals(consoleInput)) {
                    Console.WriteLine(Constants.EXIT_SLOGAN);
                    break;
                } else {
                    Console.WriteLine(Constants.INPUT_ERROR_SLOGAN);
                }
            }
        }
    }
}

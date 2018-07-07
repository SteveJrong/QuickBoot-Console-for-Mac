using System;
using System.Collections.Generic;
using EasyTools.common.@enum;

namespace QuickBootConsoleForMac.commons
{
    /// <summary>
    /// 工具模块工厂
    /// </summary>
    public class ToolModelFactory
    {
        /// <summary>
        /// 获取所有工具模块
        /// </summary>
        /// <returns>The tool model collections.</returns>
        public static Dictionary<int, string> getToolModelCollections() {
            Dictionary<int, string> allModels = new Dictionary<int, string>();
            foreach (ModelsEnum item in Enum.GetValues(typeof(ModelsEnum)))
            {
                int itemKey = ((int)item);
                string itemValue = item.ToString();
                allModels.Add(itemKey, itemValue);
            }

            return allModels;
        }
    }
}

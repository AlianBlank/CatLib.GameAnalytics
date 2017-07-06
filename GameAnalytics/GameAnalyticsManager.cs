// /*
//  * This file is part of the CatLib package.
//  *
//  * (c) Blank <wangfj11@foxmail.com>
//  * (c) URL:   http://www.alianhome.com
//  * 
//  * For the full copyright and license information, please view the LICENSE
//  * file that was distributed with this source code.
//  *
//  * Document: http://catlib.io/
//  */

using CatLib.API.Config;
using CatLib.API.GameAnalytics;
using CatLib.Stl;

namespace Assets.CatLib.GameAnalytics
{
    public class GameAnalyticsManager : SingleManager<IGameAnalytics>, IGameAnalyticsManager
    {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly IConfigManager configManager;

        /// <summary>
        /// 文件系统管理器
        /// </summary>
        public GameAnalyticsManager(IConfigManager configManager)
        {
            this.configManager = configManager;
        }

        public IGameAnalytics GameAnalytics(string name = null)
        {
            return Get(name);
        }
        /// <summary>
        /// 获取默认的文件系统名字
        /// </summary>
        /// <returns>默认的文件系统名字</returns>
        protected override string GetDefaultName()
        {
            return configManager == null ? "gameanalytics" : configManager.Default.Get("gameanalytics.default", "gameanalytics");
        }
    }
}
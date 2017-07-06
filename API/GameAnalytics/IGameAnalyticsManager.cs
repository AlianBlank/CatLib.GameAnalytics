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

using CatLib.API.Stl;

namespace CatLib.API.GameAnalytics
{
    public interface IGameAnalyticsManager : ISingleManager<IGameAnalytics>
    {
        /// <summary>
        /// 获取一个游戏数据统计解决方案
        /// </summary>
        /// <param name="name">解决方案名</param>
        /// <returns>游戏统计</returns>
        IGameAnalytics GameAnalytics(string name = null);
    }
}
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

using System.Collections.Generic;

namespace CatLib.API.GameAnalytics
{
    public interface IGameAnalytics
    {
        /// <summary>
        /// 页面时长统计,记录某个页面被打开多长时间和 PageEnd 配合使用
        /// </summary>
        /// <param name="pageName">页面名称</param>
        void PageBegin(string pageName);

        /// <summary>
        /// 页面时长统计,记录某个页面被打开多长时间和 PageBegin 配合使用
        /// </summary>
        /// <param name="pageName">页面名称</param>
        void PageEnd(string pageName);

        /// <summary>
        /// 设置是否打印SDK 的信息
        /// </summary>
        /// <param name="isEnable">是否开启Debug 日志打印</param>
        void EnabledLogPrint(bool isEnable);

        /// <summary>
        /// 属性事件
        /// </summary>
        /// <param name="eventId">事件ID</param>
        /// <param name="attributes">数值字典</param>
        void Event(string eventId, Dictionary<string, string> attributes);

        /// <summary>
        /// 计算事件数
        /// </summary>
        /// <param name="eventId">事件ID</param>
        /// <param name="attributes">数值字典</param>
        /// <param name="value">数值</param>
        void Event(string eventId, Dictionary<string, string> attributes, int value);

        /// <summary>
        /// 基本事件
        /// </summary>
        /// <param name="eventId">事件ID</param>
        /// <param name="value">事件值</param>
        void Event(string eventId, string value);

        /// <summary>
        /// 获取缓存在线参数
        /// </summary>
        /// <returns></returns>
        string GetDeviceInfo();

        /// <summary>
        /// 开始该用户Id 的统计
        /// </summary>
        /// <param name="userId"></param>
        void ProfileSignIn(string userId);

        /// <summary>
        /// 结束当前用户Id 的统计
        /// </summary>
        void ProfileSignOff();

        /// <summary>
        /// 设置玩家等级
        /// </summary>
        /// <param name="level"></param>
        void SetUserLevel(int level);

        /// <summary>
        /// 使用虚拟币购买道具
        /// </summary>
        /// <param name="propName">道具名称</param>
        /// <param name="amount">购买的道具数量</param>
        /// <param name="price">道具的价格</param>
        void VirtualCoinBuy(string propName, int amount, double price);

        /// <summary>
        /// 支付真实货币购买道具
        /// </summary>
        /// <param name="cash">真实货币的数量</param>
        /// <param name="payChannel">支付来源</param>
        /// <param name="propName">购买道具的名称</param>
        /// <param name="amount">购买的数量</param>
        /// <param name="price">单价</param>
        void Pay(double cash, int payChannel, string propName, int amount, double price);

        /// <summary>
        /// 真实消费（充值）的时候调用此方法
        /// </summary>
        /// <param name="cash">真是货币的数量</param>
        /// <param name="payChannel">支付来源</param>
        /// <param name="coin">本次消费的虚拟币</param>
        void Pay(double cash, int payChannel, double coin);

        /// <summary>
        /// 初始化数据统计SDK
        /// </summary>
        /// <param name="appKey">appKey</param>
        /// <param name="channelId">渠道来源</param>
        void Init(string appKey, string channelId);
    }
}
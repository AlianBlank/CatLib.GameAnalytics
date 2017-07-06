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
using CatLib.GameAnalytics.Adapter;
using Umeng;
using UnityEngine;

namespace CatLib.GameAnalytics.Umeng
{
    /// <summary>
    /// Android  需要添加权限
    /// 
    /// 检测联网方式，区分用户设备使用的是2G、3G或是WiFi
    /// <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
    /// 访问互联网
    /// <uses-permission android:name="android.permission.INTERNET"/>
    /// 获取用户手机的IMEI，用来唯一的标识用户
    /// <uses-permission android:name="android.permission.READ_PHONE_STATE"/>
    /// 如果您的应用会运行在无法读取IMEI的平板上，我们会将mac地址作为用户的唯一标识
    /// <uses-permission android:name="android.permission.ACCESS_WIFI_STATE"/>  
    /// </summary>
    public class UmengGameAnalyticsAdapter : IGameAnalyticsAdapter
    {
        /// <summary>
        /// 页面时长统计,记录某个页面被打开多长时间和 PageEnd 配合使用
        /// </summary>
        /// <param name="pageName">页面名称</param>
        public void PageBegin(string pageName)
        {
            GA.PageBegin(pageName);
        }

        /// <summary>
        /// 页面时长统计,记录某个页面被打开多长时间和 PageBegin 配合使用
        /// </summary>
        /// <param name="pageName">页面名称</param>
        public void PageEnd(string pageName)
        {
            GA.PageEnd(pageName);
        }

        /// <summary>
        /// 设置是否打印SDK 的信息
        /// </summary>
        /// <param name="isEnable">是否开启Debug 日志打印</param>
        public void EnabledLogPrint(bool isEnable)
        {
            GA.SetLogEnabled(isEnable);
        }

        /// <summary>
        /// 属性事件
        /// </summary>
        /// <param name="eventId">事件ID</param>
        /// <param name="attributes">数值字典</param>
        public void Event(string eventId, Dictionary<string, string> attributes)
        {
            GA.Event(eventId, attributes);
        }
        /// <summary>
        /// 计算事件数
        /// </summary>
        /// <param name="eventId">事件ID</param>
        /// <param name="attributes">数值字典</param>
        /// <param name="value">数值</param>
        public void Event(string eventId, Dictionary<string, string> attributes, int value)
        {
            GA.Event(eventId, attributes, value);
        }
        /// <summary>
        /// 基本事件
        /// </summary>
        /// <param name="eventId">事件ID</param>
        /// <param name="value">事件值</param>
        public void Event(string eventId, string value)
        {
            GA.Event(eventId, value);
        }

        /// <summary>
        /// 获取缓存在线参数
        /// </summary>
        /// <returns></returns>
        public string GetDeviceInfo()
        {
            return GA.GetDeviceInfo();
        }

        /// <summary>
        /// 开始该用户Id 的统计
        /// </summary>
        /// <param name="userId"></param>
        public void ProfileSignIn(string userId)
        {
            GA.ProfileSignIn(userId);
        }
        /// <summary>
        /// 结束当前用户Id 的统计
        /// </summary>
        public void ProfileSignOff()
        {
            GA.ProfileSignOff();
        }

        /// <summary>
        /// 设置玩家等级
        /// </summary>
        /// <param name="level"></param>
        public void SetUserLevel(int level)
        {
            GA.SetUserLevel(level);
        }

        /// <summary>
        /// 使用虚拟币购买道具
        /// </summary>
        /// <param name="propName">道具名称</param>
        /// <param name="amount">购买的道具数量</param>
        /// <param name="price">道具的价格</param>
        public void VirtualCoinBuy(string propName, int amount, double price)
        {
            GA.Buy(propName, amount, price);
        }

        /// <summary>
        /// 支付真实货币购买道具
        /// </summary>
        /// <param name="cash">真实货币的数量</param>
        /// <param name="payChannel">支付来源</param>
        /// <param name="propName">购买道具的名称</param>
        /// <param name="amount">购买的数量</param>
        /// <param name="price">单价</param>
        public void Pay(double cash, int payChannel, string propName, int amount, double price)
        {
            GA.Pay(cash, (GA.PaySource)payChannel, propName, amount, price);
        }

        /// <summary>
        /// 真实消费（充值）的时候调用此方法
        /// </summary>
        /// <param name="cash">真是货币的数量</param>
        /// <param name="payChannel">支付来源</param>
        /// <param name="coin">本次消费的虚拟币</param>
        public void Pay(double cash, int payChannel, double coin)
        {
            GA.Pay(cash, payChannel, coin);
        }

        /// <summary>
        /// 初始化数据统计SDK
        /// </summary>
        /// <param name="appKey">appKey</param>
        /// <param name="channelId">渠道来源</param>
        public void Init(string appKey, string channelId)
        {
            Debug.Log(appKey);
            GA.StartWithAppKeyAndChannelId(appKey, channelId);
        }
    }
}
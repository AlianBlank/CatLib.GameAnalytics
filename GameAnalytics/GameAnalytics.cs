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
using CatLib.API.GameAnalytics;
using CatLib.GameAnalytics.Adapter;
using CatLib.Stl;

namespace Assets.CatLib.GameAnalytics
{
    public class GameAnalytics : IGameAnalytics
    {
        private readonly IGameAnalyticsAdapter adapter;

        public GameAnalytics(IGameAnalyticsAdapter gameAnalyticsAdapter)
        {
            Guard.NotNull(gameAnalyticsAdapter, "gameAnalyticsAdapter");
            this.adapter = gameAnalyticsAdapter;
        }

        public void PageBegin(string pageName)
        {
            adapter.PageBegin(pageName);
        }

        public void PageEnd(string pageName)
        {
            adapter.PageEnd(pageName);
        }

        public void EnabledLogPrint(bool isEnable)
        {
            adapter.EnabledLogPrint(isEnable);
        }

        public void Event(string eventId, Dictionary<string, string> attributes)
        {
            adapter.Event(eventId, attributes);
        }

        public void Event(string eventId, Dictionary<string, string> attributes, int value)
        {
            adapter.Event(eventId, attributes, value);
        }

        public void Event(string eventId, string value)
        {
            adapter.Event(eventId, value);
        }

        public string GetDeviceInfo()
        {
            return adapter.GetDeviceInfo();
        }

        public void ProfileSignIn(string userId)
        {
            adapter.ProfileSignIn(userId);
        }

        public void ProfileSignOff()
        {
            adapter.ProfileSignOff();
        }

        public void SetUserLevel(int level)
        {
            adapter.SetUserLevel(level);
        }

        public void VirtualCoinBuy(string propName, int amount, double price)
        {
            adapter.VirtualCoinBuy(propName, amount, price);
        }

        public void Pay(double cash, int payChannel, string propName, int amount, double price)
        {
            adapter.Pay(cash, payChannel, propName, amount, price);
        }

        public void Pay(double cash, int payChannel, double coin)
        {
            adapter.Pay(cash, payChannel, coin);
        }

        public void Init(string appKey, string channelId)
        {
            adapter.Init(appKey, channelId);
        }
    }
}
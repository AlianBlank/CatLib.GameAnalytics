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

using System.Collections;
using CatLib;
using CatLib.API;
using CatLib.API.GameAnalytics;
using CatLib.GameAnalytics.Umeng;

namespace Assets.CatLib.GameAnalytics
{
    public class GameAnalyticsProvider : ServiceProvider
    {
        public override void Register()
        {
            App.Singleton<GameAnalyticsManager>().Alias<IGameAnalyticsManager>().Alias("gameanalytics.manager");
        }

        public override IEnumerator Init()
        {
            var storage = App.Make<IGameAnalyticsManager>();
            var env = App.Make<IEnv>();

            if (env != null)
            {
                storage.Extend(() => new GameAnalytics(new UmengGameAnalyticsAdapter()));
            }
            return base.Init();
        }
    }
}
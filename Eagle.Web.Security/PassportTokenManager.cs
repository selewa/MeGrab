using Eagle.Core.Application;
using Eagle.Web.Caches;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Eagle.Web.Security
{
    public sealed class PassportTokenManager
    {
        private static readonly PassportTokenManager passportTokenManager = new PassportTokenManager();

        private PassportTokenManager() { }

        public static PassportTokenManager Instance
        {
            get 
            {
                return passportTokenManager;
            }
        }
        
        public PassportTokenItem GetPassportTokenItem(string token)
        {
            using (IRedisClient redisClient = this.CreateRedisClient())
            {
                PassportTokenItem tokenItem = redisClient.Get<PassportTokenItem>(token);
                return tokenItem;
            }
        }

        public bool ExistsToken(string token)
        {
            using (IRedisClient redisClient = this.CreateRedisClient())
            {
                return redisClient.ContainsKey(token);
            }
        }

        public void AddToken(string token, PassportAuthenticationTicket credential, DateTime expire)
        {
           using (IRedisClient redisClient = this.CreateRedisClient())
           {
               if (!redisClient.ContainsKey(token))
               {
                   PassportTokenItem tokenItem = new PassportTokenItem(token, credential, expire);
                   redisClient.Set<PassportTokenItem>(token, tokenItem, expire);
               }
               else
               {
                  PassportTokenItem tokenItem = redisClient.Get<PassportTokenItem>(token);
                  tokenItem.Expire = expire;
                  redisClient.Set<PassportTokenItem>(token, tokenItem, expire);
               }
           }
        }

        private IRedisClient CreateRedisClient()
        {
            string writeServerList = AppRuntime.Instance.CurrentApplication.ConfigSource.Config.Redis.WriteHosts;
            string readOnlyServerList = AppRuntime.Instance.CurrentApplication.ConfigSource.Config.Redis.ReadOnlyHosts;

            string[] writeHosts = writeServerList.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string[] readOnlyHosts = readOnlyServerList.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            PooledRedisClientManager redisClientManager = new PooledRedisClientManager(writeHosts, readOnlyHosts);

            return redisClientManager.GetClient();
        }

    }
}

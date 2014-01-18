using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Service.Handler;
using TaoClothes.Service.Handler.HandlerInterface;

namespace TaoClothes.Service.Request
{
    /// <summary>
    /// HttpPost请求
    /// </summary>
    public class HttpPostRequest : RequestBase
    {
        #region 构造函数

        public HttpPostRequest(string content)
        {
            this.RequestMethod = RequestMethod.POST;
            this.Content = content;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 获取响应
        /// </summary>
        /// <returns></returns>
        internal protected override string GetResponse()
        {
            string requestXml = Content;
            IHandler handler = HandlerFactory.CreateHandler(requestXml);
            if (handler != null)
            {
                return handler.HandleRequest();
            }

            return string.Empty;
        }

        #endregion
    }
}

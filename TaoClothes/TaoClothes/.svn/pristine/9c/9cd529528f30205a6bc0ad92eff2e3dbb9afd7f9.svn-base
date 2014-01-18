using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoClothes.Service.Request
{
    public abstract class RequestBase
    {
        #region 字段

        /// <summary>
        /// 请求方式
        /// </summary>
        protected RequestMethod RequestMethod { get; set; }

        /// <summary>
        /// Post请求内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Get请求参数
        /// </summary>
        public Dictionary<string, string> QueryString = null;

        #endregion

        #region 构造函数

        protected RequestBase() { }

        protected RequestBase(RequestMethod requestMethod, string content, Dictionary<string, string> queryString)
        {
            this.RequestMethod = requestMethod;
            this.Content = content;
            this.QueryString = queryString;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 获取响应
        /// </summary>
        /// <returns></returns>
        internal protected abstract string GetResponse();

        #endregion
    }
}

using TaoClothes.Service.Request;

namespace TaoClothes.Service
{
    /// <summary>
    /// 微信公众平台服务
    /// </summary>
    public class WeixinService
    {
        #region 字段

        /// <summary>
        /// Http请求
        /// </summary>
        private RequestBase Request { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="request"></param>
        public WeixinService(RequestBase request)
        {
            this.Request = request;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 处理请求，产生响应
        /// </summary>
        /// <returns></returns>
        public string GetResponse()
        {
            return this.Request.GetResponse();
        }

        #endregion
    }
}

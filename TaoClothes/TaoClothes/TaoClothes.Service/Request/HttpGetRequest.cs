using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Service.Utility;

namespace TaoClothes.Service.Request
{
    public class HttpGetRequest : RequestBase
    {
        #region 常量

        /// <summary>
        /// TOKEN
        /// </summary>
        private const string CONST_TOKEN = "1bd22e5a1a6e756c";
        /// <summary>
        /// 签名
        /// </summary>
        private const string CONST_SIGNATURE = "signature";
        /// <summary>
        /// 时间戳
        /// </summary>
        private const string CONST_TIMESTAMP = "timestamp";
        /// <summary>
        /// 随机数
        /// </summary>
        private const string CONST_NONCE = "nonce";
        /// <summary>
        /// 随机字符串
        /// </summary>
        private const string CONST_ECHOSTR = "echostr";
        /// <summary>
        /// GET请求方式
        /// </summary>
        private const string CONST_GET = "GET";
        /// <summary>
        /// POST请求方式
        /// </summary>
        private const string CONST_POST = "POST";
        /// <summary>
        /// 验证签名错误
        /// </summary>
        private const string MSG_SIGNATURE_ERROR = "验证签名错误";
        /// <summary>
        /// 不支持此请求方式
        /// </summary>
        private const string MSG_NOT_SUPPORT_REQUEST_METHOD = "不支持此请求方式";

        #endregion

        #region 构造函数

        public HttpGetRequest(Dictionary<string, string> queryString)
        {
            this.RequestMethod = RequestMethod.GET;
            this.QueryString = queryString;
        }

        #endregion

        #region 方法
        internal protected override string GetResponse()
        {
            //验证签名
            if (CheckSignature())
            {
                return QueryString[CONST_ECHOSTR];
            }
            else
            {
                return MSG_SIGNATURE_ERROR;
            }
        }

        /// <summary>
        /// 检查签名
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private bool CheckSignature()
        {
            string signature = QueryString[CONST_SIGNATURE];
            string timestamp = QueryString[CONST_TIMESTAMP];
            string nonce = QueryString[CONST_NONCE];

            List<string> list = new List<string>();
            list.Add(CONST_TOKEN);
            list.Add(timestamp);
            list.Add(nonce);
            //排序
            list.Sort();
            //拼串
            string input = string.Empty;
            foreach (var item in list)
            {
                input += item;
            }
            //加密
            string new_signature = SecurityUtility.SHA1Encrypt(input);
            //验证
            if (new_signature == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}

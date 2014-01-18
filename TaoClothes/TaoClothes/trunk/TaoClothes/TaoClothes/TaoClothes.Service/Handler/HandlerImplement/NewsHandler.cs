using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Service.Handler.HandlerInterface;
using TaoClothes.Service.Message.ReceiveMessage;
using TaoClothes.Service.Message.SendMessage;

namespace TaoClothes.Service.Handler.HandlerImplement
{
    internal class NewsHandler : IHandler
    {
        #region 字段

        /// <summary>
        /// 请求的XML
        /// </summary>
        private string RequestXml { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="requestXml">请求的xml</param>
        internal NewsHandler(string requestXml)
        {
            this.RequestXml = requestXml;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        public string HandleRequest()
        {
            ReceiveTextMessage receiveTextMessage = new ReceiveTextMessage(this.RequestXml);
            SendNewsMessage sendNewsMessage = new SendNewsMessage();
            sendNewsMessage.ToUserName = receiveTextMessage.FromUserName;
            sendNewsMessage.FromUserName = receiveTextMessage.ToUserName;
            sendNewsMessage.Articles.Add(new Article()
            {
                Title = "淘衣服微信公众账号测试一标题",
                Description = "淘衣服微信公众账号测试一描述",
                PicUrl = "http://www.womanquan.com/themes/shishangqiyi/img/lb/s2.jpg",
                Url = "http://taoclothes.apphb.com/Index.aspx?goodsId=5"
            });
            sendNewsMessage.Articles.Add(new Article()
            {
                Title = "淘衣服微信公众账号测试二标题",
                Description = "淘衣服微信公众账号测试二描述",
                PicUrl = "http://www.womanquan.com/themes/shishangqiyi/img/lb/s4.jpg",
                Url = "http://taoclothes.apphb.com/Index.aspx?goodsId=16"
            });
            return sendNewsMessage.GenerateXmlContent();
        }

        #endregion
    }
}

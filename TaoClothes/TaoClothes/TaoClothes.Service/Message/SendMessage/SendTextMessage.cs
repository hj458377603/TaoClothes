using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoClothes.Service.Request;

namespace TaoClothes.Service.Message.SendMessage
{
    internal class SendTextMessage : SendMessageBase
    {
        #region 字段

        /// <summary>
        /// 内容
        /// </summary>
        internal string Content { get; set; }

        #endregion

        #region 构造方法

        /// <summary>
        /// 构造方法
        /// </summary>
        internal SendTextMessage()
        {
            Init();
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        internal SendTextMessage(string toUserName, string fromUserName, string content)
        {
            Init();
        }

        #endregion

        #region 方法

        /// <summary>
        /// 生成Xml格式发送消息
        /// </summary>
        /// <returns></returns>
        internal override string GenerateXmlContent()
        {
            this.CreateTime = CommonHelper.GetNowTime();
            this.MsgType = "text";
            return string.Format(this.XmlTemplate, this.ToUserName, this.FromUserName, this.CreateTime, this.MsgType, this.Content);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            //            @"<xml>
            //                <ToUserName><![CDATA[{0}]]></ToUserName>
            //                <FromUserName><![CDATA[{1}]]></FromUserName>
            //                <CreateTime>{2}</CreateTime>
            //                <MsgType><![CDATA[{3}]]></MsgType>
            //                <Content><![CDATA[{4}]]></Content>
            //            </xml>";
            this.XmlTemplate = @"<xml><ToUserName><![CDATA[{0}]]></ToUserName><FromUserName><![CDATA[{1}]]></FromUserName><CreateTime>{2}</CreateTime><MsgType><![CDATA[{3}]]></MsgType><Content><![CDATA[{4}]]></Content></xml>";
        }

        #endregion
    }
}
